using Newtonsoft.Json;

namespace Models.Insightly
{
    public class LeadSource
    {
        [JsonProperty("LEAD_SOURCE_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? LEAD_SOURCE_ID { get; set; }

        [JsonProperty("LEAD_SOURCE", NullValueHandling = NullValueHandling.Ignore)]
        public string LEAD_SOURCE { get; set; }

        [JsonProperty("DEFAULT_VALUE", NullValueHandling = NullValueHandling.Ignore)]
        public bool DEFAULT_VALUE { get; set; }

        [JsonProperty("FIELD_ORDER", NullValueHandling = NullValueHandling.Ignore)]
        public long? FIELD_ORDER { get; set; }
    }
}
