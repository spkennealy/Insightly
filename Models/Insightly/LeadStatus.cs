using Newtonsoft.Json;

namespace Models.Insightly
{
    public class LeadStatus
    {
        [JsonProperty("LEAD_STATUS_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? LEAD_STATUS_ID { get; set; }

        [JsonProperty("LEAD_STATUS", NullValueHandling = NullValueHandling.Ignore)]
        public string LEAD_STATUS { get; set; }

        [JsonProperty("DEFAULT_STATUS", NullValueHandling = NullValueHandling.Ignore)]
        public bool DEFAULT_STATUS { get; set; }

        [JsonProperty("STATUS_TYPE", NullValueHandling = NullValueHandling.Ignore)]
        public long? STATUS_TYPE { get; set; }

        [JsonProperty("FIELD_ORDER", NullValueHandling = NullValueHandling.Ignore)]
        public long? FIELD_ORDER { get; set; }
    }
}
