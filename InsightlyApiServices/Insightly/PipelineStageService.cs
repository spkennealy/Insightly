using System.Threading.Tasks;
using Models.Insightly;

namespace Services.Insightly
{
    public class PipelineStageService : BaseService<PipelineStage>
    {
        public PipelineStageService(string apiKey) : base(apiKey, "PipelineStages")
        {
        }

        public async Task<PipelineStage> Get(long id)
        {
            return await apiClient.GetAsync<PipelineStage>($"{objectUrl}/{id}");
        }
    }
}
