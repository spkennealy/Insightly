using Newtonsoft.Json;

namespace Models.Shopify
{
    public class TaxLine
    {
        [JsonProperty("title")]
        public string TITLE { get; set; }

        [JsonProperty("rate")]
        public string RATE { get; set; }

        [JsonProperty("price")]
        public string PRICE { get; set; }
    }
}
