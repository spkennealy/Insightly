using Newtonsoft.Json;

namespace Models.Freshdesk
{
    public class FDSearchResult
    {
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? TOTAL { get; set; }

        [JsonProperty("results", NullValueHandling = NullValueHandling.Ignore)]
        public object RESULTS { get; set; }
    }
}
