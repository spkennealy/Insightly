using Newtonsoft.Json;

namespace Models.Shopify
{
    public class TempFulfillment
    {
        [JsonProperty("fulfillment_id")]
        public long? FULFILLMENT_ID { get; set; }

        [JsonProperty("order_id")]
        public long? ORDER_ID { get; set; }
    }
}
