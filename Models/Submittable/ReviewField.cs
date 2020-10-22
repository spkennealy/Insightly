using Newtonsoft.Json;

namespace Models.Submittable
{
    public class ReviewField
    {
        [JsonProperty("field_type", NullValueHandling = NullValueHandling.Ignore)]
        public string FIELD_TYPE { get; set; }

        [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
        public string LABEL { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public string DATA { get; set; }

        [JsonProperty("scoring_value", NullValueHandling = NullValueHandling.Ignore)]
        public int? SCORING_VALUE { get; set; }

        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
        public int? ORDER { get; set; }
    }
}
