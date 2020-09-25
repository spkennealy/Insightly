using Newtonsoft.Json;

namespace Models.Insightly
{
    public class Pipeline
    {
        [JsonProperty("PIPELINE_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? PIPELINE_ID { get; set; }

        [JsonProperty("PIPELINE_NAME", NullValueHandling = NullValueHandling.Ignore)]
        public string PIPELINE_NAME { get; set; }

        [JsonProperty("FOR_OPPORTUNITIES", NullValueHandling = NullValueHandling.Ignore)]
        public bool FOR_OPPORTUNITIES { get; set; }

        [JsonProperty("FOR_PROJECTS", NullValueHandling = NullValueHandling.Ignore)]
        public bool FOR_PROJECTS { get; set; }

        [JsonProperty("OWNER_USER_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? OWNER_USER_ID { get; set; }

        [JsonProperty("PIPELINE_STAGE_CHANGE", NullValueHandling = NullValueHandling.Ignore)]
        public PipelineStageChange PIPELINE_STAGE_CHANGE { get; set; }
    }
}
