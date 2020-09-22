using Newtonsoft.Json;

namespace Models.Insightly
{
    public class InsightlyRecordWrapper
    {
        [JsonProperty("recordId")]
        public long? RECORD_ID { get; set; }

        [JsonProperty("recordType")]
        public string RECORD_TYPE { get; set; }

        [JsonProperty("operation")]
        public string OPERATION { get; set; }

        [JsonProperty("newValue")]
        public object NEW_VALUE { get; set; }

        [JsonProperty("oldEntity", NullValueHandling = NullValueHandling.Ignore)]
        public object OLD_VALUE { get; set; }
    }
}
