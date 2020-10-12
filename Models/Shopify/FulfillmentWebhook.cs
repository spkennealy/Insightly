using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Models.Shopify
{
    public class FulfillmentWebhook
    {
        [JsonProperty("id")]
        public long? ID { get; set; }

        [JsonProperty("order_id")]
        public long? ORDER_ID { get; set; }

        [JsonProperty("status")]
        public string STATUS { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CREATED_AT { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UPDATED_AT { get; set; }

        [JsonProperty("tracking_company")]
        public string TRACKING_COMPANY { get; set; }

        [JsonProperty("shipment_status")]
        public string SHIPMENT_STATUS { get; set; }

        [JsonProperty("location_id")]
        public long? LOCATION_ID { get; set; }

        [JsonProperty("email")]
        public string EMAIL { get; set; }

        [JsonProperty("destination")]
        public Address DESTINATION { get; set; }

        [JsonProperty("tracking_number")]
        public string TRACKING_NUMBER { get; set; }

        [JsonProperty("tracking_numbers")]
        public List<string> TRACKING_NUMBERS { get; set; }

        [JsonProperty("tracking_url")]
        public string TRACKING_URL { get; set; }

        [JsonProperty("tracking_urls")]
        public List<string> TRACKING_URLS { get; set; }

        [JsonProperty("name")]
        public string NAME { get; set; }

        [JsonProperty("line_items")]
        public List<LineItem> LINE_ITEMS { get; set; }
    }
}
