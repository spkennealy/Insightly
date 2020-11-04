using System.Threading.Tasks;

namespace Services.Insightly
{
    public abstract class BaseService<T>
        where T : class, new()
    {
        private readonly string apiKey;
        public readonly string objectUrl;
        public readonly ApiClient apiClient;
        private const int TOP = 500;

        public BaseService(string apiKey, string objectUrl)
        {
            this.apiKey = apiKey;
            this.objectUrl = objectUrl;
            apiClient = new ApiClient(apiKey);
        }

        internal async Task<TResult> GetByUrlAsync<TResult>(string url)
        {
            return await apiClient.GetAsync<TResult>($"{objectUrl}/{url}");
        }
    }
}
