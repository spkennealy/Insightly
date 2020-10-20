using Newtonsoft.Json;

namespace Models.Shopify
{
    public class Variant
    {
        [JsonProperty("id")]
        public long? ID { get; set; }

        [JsonProperty("product_id")]
        public long? PRODUCT_ID { get; set; }

        [JsonProperty("sku")]
        public string SKU { get; set; }
    }
}