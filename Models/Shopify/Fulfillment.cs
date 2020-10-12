using System;
using Newtonsoft.Json;

namespace Models.Shopify
{
    public class Fulfillment
    {
        [JsonProperty("created_at")]
        public DateTime? CREATED_AT { get; set; }

        [JsonProperty("id")]
        public long? ID { get; set; }

        [JsonProperty("order_id")]
        public long? ORDER_ID { get; set; }

        [JsonProperty("status")]
        public string STATUS { get; set; }

        [JsonProperty("tracking_company")]
        public string TRACKING_COMPANY { get; set; }

        [JsonProperty("tracking_number")]
        public string TRACKING_NUMBER { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UPDATED_AT { get; set; }
    }
}
