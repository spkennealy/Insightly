using System.Threading.Tasks;
using Models.Insightly;

namespace Services.Insightly
{
    public class PipelineService : BaseService<Pipeline>
    {
        public PipelineService(string apiKey) : base(apiKey, "Pipelines")
        {
        }

        public async Task<Pipeline> Get(long id)
        {
            return await apiClient.GetAsync<Pipeline>($"{objectUrl}/{id}");
        }
    }
}
