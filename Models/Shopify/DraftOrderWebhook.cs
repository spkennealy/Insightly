using Newtonsoft.Json;

namespace Models.Shopify
{
    public class DraftOrderWebhook
    {
        [JsonProperty("id")]
        public long? ID { get; set; }

        [JsonProperty("order_id")]
        public long? ORDER_ID { get; set; }
    }
}
