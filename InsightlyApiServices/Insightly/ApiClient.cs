using Common.Tools;
using HeyRed.Mime;
using Models.Insightly;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using Tools;

namespace Services.Insightly
{
    public class ApiClient
    {
        private readonly string apiKey;
        private const string BaseUrl = "https://api.insightly.com/v3.1";
        //private const string BaseUrl = "https://api.insightlystage01.com/v3.1"; // For testing
        private const string RETRY_AFTER = "Retry-After";
        private static TimeSpan DEFAULT_DELAY = TimeSpan.FromSeconds(3);

        public ApiClient(string apiKey)
        {
            this.apiKey = apiKey;
        }

        public async Task<HttpResponseMessage> GetResponseAsync(string url)
        {
            using (var client = new HttpClient())
            {
                AddHeaders(client);
                var response = await client.GetAsync($"{BaseUrl}/{url}");
                if (!response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.TooManyRequests)
                    {
                        response = await Retry(() => client.GetAsync($"{BaseUrl}/{url}"), response?.Headers?.RetryAfter?.Delta);
                    }
                    else
                    {
                        var resultString = response.Content.ReadAsStringAsync().Result;
                        Utils.LogMessage($"ERROR: {resultString}");
                    }
                }
                return response;
            }
        }

        public async Task<T> GetAsync<T>(string url)
        {
            using (var client = new HttpClient())
            {
                AddHeaders(client);
                var response = await client.GetAsync($"{BaseUrl}/{url}").ConfigureAwait(false);
                if (!response.IsSuccessStatusCode && response.StatusCode == System.Net.HttpStatusCode.TooManyRequests)
                {
                    response = await Retry(() => client.GetAsync($"{BaseUrl}/{url}"), response?.Headers?.RetryAfter?.Delta);
                }
                return await GetResultAsync<T>(response);
            }
        }

        public async Task<T> PostAsync<T>(T obj, string url)
        {
            using (var client = new HttpClient())
            {
                AddHeaders(client);
                var response = await client.PostAsync($"{BaseUrl}/{url}", GetBody(obj)).ConfigureAwait(false);
                if (!response.IsSuccessStatusCode && response.StatusCode == System.Net.HttpStatusCode.TooManyRequests)
                {
                    response = await Retry(() => client.PostAsync($"{BaseUrl}/{url}", GetBody(obj)), response?.Headers?.RetryAfter?.Delta);
                }
                return await GetResultAsync<T>(response);
            }
        }

        public async Task<FileAttachment> PostFileAsync(string filePath, string fileName, string url)
        {
            var client = new RestClient($"{BaseUrl}/{url}");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Accept", "application/json, text/json");
            request.AddHeader("Content-Type", "multipart/form-data");
            request.AddHeader("Authorization", $"Basic {Utils.EncodeBase64(apiKey)}");
            request.AddFile("file", filePath);
            request.AddParameter("file_name", fileName);
            request.AddParameter("content_type", MimeTypesMap.GetMimeType(fileName));
            IRestResponse response = await client.ExecuteAsync(request);

            return Serializer.FromJson<FileAttachment>(response.Content);
        }

        public async Task<T> PutAsync<T>(T obj, string url)
        {
            using (var client = new HttpClient())
            {
                AddHeaders(client);
                var response = await client.PutAsync($"{BaseUrl}/{url}", GetBody(obj)).ConfigureAwait(false);
                if (!response.IsSuccessStatusCode && response.StatusCode == System.Net.HttpStatusCode.TooManyRequests)
                {
                    response = await Retry(() => client.PutAsync($"{BaseUrl}/{url}", GetBody(obj)), response?.Headers?.RetryAfter?.Delta);
                }
                return await GetResultAsync<T>(response);
            }
        }

        public async Task<bool> DeleteAsync<T>(string url)
        {
            using (var client = new HttpClient())
            {
                AddHeaders(client);
                var response = await client.DeleteAsync($"{BaseUrl}/{url}").ConfigureAwait(false);
                if (!response.IsSuccessStatusCode && response.StatusCode == System.Net.HttpStatusCode.TooManyRequests)
                {
                    response = await Retry(() => client.DeleteAsync($"{BaseUrl}/{url}"), response?.Headers?.RetryAfter?.Delta);
                }
                return response.IsSuccessStatusCode;
            }
        }

        private void AddHeaders(HttpClient client)
        {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Utils.EncodeBase64(apiKey));
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        private StringContent GetBody(object obj)
        {
            var body = new StringContent(JsonConvert.SerializeObject(obj));
            body.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            return body;
        }

        private ByteArrayContent GetFileBody(byte[] obj, string fileName)
        {
            var body = new ByteArrayContent(obj);
            body.Headers.ContentType = new MediaTypeHeaderValue(MimeTypesMap.GetMimeType(fileName));
            return body;
        }

        private async Task<T> GetResultAsync<T>(HttpResponseMessage response)
        {
            return await response.Content.ReadAsStringAsync().ContinueWith(x =>
            {
                if (x.IsFaulted)
                {
                    Utils.LogMessage($"ERROR: {response.Content.ReadAsStringAsync()}");
                    throw x.Exception;
                }

                return response.IsSuccessStatusCode
                    ? JsonConvert.DeserializeObject<T>(x.Result)
                    : throw new Exception(x.Result);
            });
        }

        protected async Task<HttpResponseMessage> Retry(Func<Task<HttpResponseMessage>> action, TimeSpan? retryInterval, int maxAttemptCount = 15)
        {
            var exceptions = new List<Exception>();

            for (int attempted = 1; attempted <= maxAttemptCount; attempted++)
            {
                try
                {
                    var sleepTime = retryInterval != null ? retryInterval.Value : TimeSpan.FromSeconds(Math.Pow(1.25, attempted));
                    Thread.Sleep(sleepTime);
                    var result = await action();

                    if (!result.IsSuccessStatusCode)
                    {
                        var resultString = result.Content.ReadAsStringAsync().Result;
                        Utils.LogMessage($"API Limit Error Count: {attempted}");
                        exceptions.Add(new Exception(resultString));
                    }
                    else
                    {
                        return result;
                    }
                }
                catch (Exception ex)
                {
                    exceptions.Add(ex);
                }
            }
            throw new AggregateException(exceptions);
        }
    }
}
