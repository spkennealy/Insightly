using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Services.Insightly
{
    // Service to Create Read Update or Delete (CRUD)
    public abstract class CrudService<T> : BaseService<T>
        where T : class, new()
    {
        private const int TOP = 500;

        public CrudService(string apiKey, string objectUrl) : base(apiKey, objectUrl)
        {
        }

        internal async Task<T> Get(long id)
        {
            return await GetByUrlAsync<T>(id.ToString());
        }

        internal async Task<IEnumerable<T>> Search(string field, object value)
        {
            var loopCount = 0;
            IEnumerable<T> results = new List<T>();
            long? skip = 0;
            long? totalResults = null;

            while (results.Count() < totalResults || (totalResults == null && loopCount == 0))
            {
                loopCount += 1;
                var response = await apiClient.GetAllAsync<T>($"{objectUrl}/Search?field_name={field}&field_value={value}&count_total=true&top={Constants.TOP_500}&skip={skip}");

                if (response.IsSuccessStatusCode)
                {
                    if (totalResults == null) totalResults = Convert.ToInt64(response.Headers.Where(h => h.Key == "X-Total-Count").FirstOrDefault().Value.FirstOrDefault());

                    var resultString = await response.Content.ReadAsStringAsync();
                    if (resultString.Length == 0)
                        break;

                    var fetchedCustomObjects = JsonConvert.DeserializeObject<IEnumerable<T>>(resultString);
                    results = results.Concat(fetchedCustomObjects);
                }

                skip += TOP;
            }

            return results;
        }

        internal async Task<IEnumerable<T>> SearchUpdatedAfterDate(object date)
        {
            var loopCount = 0;
            IEnumerable<T> results = new List<T>();
            long? skip = 0;
            long? totalResults = null;

            while (results.Count() < totalResults || (totalResults == null && loopCount == 0))
            {
                loopCount += 1;
                var response = await apiClient.GetAllAsync<T>($"{objectUrl}/Search?updated_after_utc={date}&count_total=true&top={Constants.TOP_500}&skip={skip}");

                if (response.IsSuccessStatusCode)
                {
                    if (totalResults == null) totalResults = Convert.ToInt64(response.Headers.Where(h => h.Key == "X-Total-Count").FirstOrDefault().Value.FirstOrDefault());

                    var resultString = await response.Content.ReadAsStringAsync();
                    if (resultString.Length == 0)
                        break;

                    var fetchedCustomObjects = JsonConvert.DeserializeObject<IEnumerable<T>>(resultString);
                    results = results.Concat(fetchedCustomObjects);
                }

                skip += TOP;
            }

            return results;
        }

        internal async Task<IEnumerable<T>> GetAll()
        {
            var loopCount = 0;
            IEnumerable<T> results = new List<T>();
            long? skip = 0;
            long? totalResults = null;

            while (results.Count() < totalResults || (totalResults == null && loopCount == 0))
            {
                loopCount += 1;
                var response = await apiClient.GetAllAsync<T>($"{objectUrl}?count_total=true&top={Constants.TOP_500}&skip={skip}");

                if (response.IsSuccessStatusCode)
                {
                    if (totalResults == null) totalResults = Convert.ToInt64(response.Headers.Where(h => h.Key == "X-Total-Count").FirstOrDefault().Value.FirstOrDefault());

                    var resultString = await response.Content.ReadAsStringAsync();
                    if (resultString.Length == 0)
                        break;

                    var fetchedCustomObjects = JsonConvert.DeserializeObject<IEnumerable<T>>(resultString);
                    results = results.Concat(fetchedCustomObjects);
                }

                skip += TOP;
            }

            return results;
        }

        internal async Task<T> Create(T obj)
        {
            return await apiClient.PostAsync(obj, objectUrl);
        }

        internal async Task<T> Update(T obj)
        {
            return await apiClient.PutAsync(obj, objectUrl);
        }

        internal async Task<bool> Delete(long id)
        {
            return await apiClient.DeleteAsync<T>($"{objectUrl}/{id}");
        }
    }
}
