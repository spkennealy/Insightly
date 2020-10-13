using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Models.Shopify
{
    public class Order
    {
        [JsonProperty("id")]
        public long? ID { get; set; }

        [JsonProperty("email")]
        public string EMAIL { get; set; }

        [JsonProperty("closed_at")]
        public DateTime? CLOSED_AT { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CREATED_AT { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UPDATED_AT { get; set; }

        [JsonProperty("number")]
        public int? NUMBER { get; set; }

        [JsonProperty("note")]
        public string NOTE { get; set; }

        [JsonProperty("token")]
        public string TOKEN { get; set; }

        [JsonProperty("gateway")]
        public string GATEWAY { get; set; }

        [JsonProperty("test")]
        public bool TEST { get; set; }

        [JsonProperty("total_price")]
        public string TOTAL_PRICE { get; set; }

        [JsonProperty("subtotal_price")]
        public double? SUBTOTAL_PRICE { get; set; }

        [JsonProperty("total_weight")]
        public double? TOTAL_WEIGHT { get; set; }

        [JsonProperty("total_tax")]
        public double? TOTAL_TAX { get; set; }

        [JsonProperty("fulfillment_status")]
        public string FULFILLMENT_STATUS { get; set; }

        [JsonProperty("fulfillments")]
        public List<Fulfillment> FULFILLMENTS { get; set; }

        [JsonProperty("name")]
        public string NAME { get; set; }
    }
}
