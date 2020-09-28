using Newtonsoft.Json;

namespace Models.Insightly
{
    public class PipelineStageChange
    {
        [JsonProperty("STAGE_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? STAGE_ID { get; set; }
    }
}
