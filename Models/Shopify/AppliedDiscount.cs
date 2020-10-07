using Newtonsoft.Json;

namespace Models.Shopify
{
    public class AppliedDiscount
    {
        [JsonProperty("title")]
        public string TITLE { get; set; }

        [JsonProperty("description")]
        public string DESCRIPTION { get; set; }

        [JsonProperty("value")]
        public string VALUE { get; set; }

        [JsonProperty("value_type")]
        public string VALUE_TYPE { get; set; }

        [JsonProperty("amount")]
        public string AMOUNT { get; set; }
    }
}
