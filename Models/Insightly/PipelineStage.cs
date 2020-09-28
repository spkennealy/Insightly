using Newtonsoft.Json;

namespace Models.Insightly
{
    public class PipelineStage
    {
        [JsonProperty("STAGE_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? STAGE_ID { get; set; }

        [JsonProperty("PIPELINE_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? PIPELINE_ID { get; set; }

        [JsonProperty("STAGE_NAME", NullValueHandling = NullValueHandling.Ignore)]
        public string STAGE_NAME { get; set; }

        [JsonProperty("STAGE_ORDER", NullValueHandling = NullValueHandling.Ignore)]
        public int? STAGE_ORDER { get; set; }

        [JsonProperty("ACTIVITYSET_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? ACTIVITYSET_ID { get; set; }

        [JsonProperty("OWNER_USER_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? OWNER_USER_ID { get; set; }
    }
}
