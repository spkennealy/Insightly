using Newtonsoft.Json;

namespace Models.Shopify
{
    public class ShippingLine
    {
        [JsonProperty("id")]
        public long? ID { get; set; }

        [JsonProperty("handle")]
        public string HANDLE { get; set; }

        [JsonProperty("price")]
        public double? PRICE { get; set; }

        [JsonProperty("title")]
        public string TITLE { get; set; }

        [JsonProperty("custom")]
        public bool CUSTOM { get; set; }
    }
}
