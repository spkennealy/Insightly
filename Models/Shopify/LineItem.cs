using System.Collections.Generic;
using Newtonsoft.Json;

namespace Models.Shopify
{
    public class LineItem
    {
        [JsonProperty("custom")]
        public bool CUSTOM { get; set; }

        [JsonProperty("fulfillable_quantity")]
        public int? FULFILLABLE_QUANTITY { get; set; }

        [JsonProperty("fulfillment_service")]
        public string FULFILLMENT_SERVICE { get; set; }

        [JsonProperty("grams")]
        public int? GRAMS { get; set; }

        [JsonProperty("id")]
        public long? ID { get; set; }

        [JsonProperty("price")]
        public string PRICE { get; set; }

        [JsonProperty("product_id")]
        public long? PRODUCT_ID { get; set; }

        [JsonProperty("quantity")]
        public int QUANTITY { get; set; }

        [JsonProperty("requires_shipping")]
        public bool REQUIRES_SHIPPING { get; set; }

        [JsonProperty("sku")]
        public string SKU { get; set; }

        [JsonProperty("title")]
        public string TITLE { get; set; }

        [JsonProperty("variant_id")]
        public long? VARIANT_ID { get; set; }

        [JsonProperty("variant_title")]
        public string VARIANT_TITLE { get; set; }

        [JsonProperty("vendor")]
        public string VENDOR { get; set; }

        [JsonProperty("name")]
        public string NAME { get; set; }

        [JsonProperty("gift_card")]
        public bool GIFT_CARD { get; set; }

        [JsonProperty("properties")]
        public List<Obj> PROPERTIES { get; set; }

        [JsonProperty("taxable")]
        public bool TAXABLE { get; set; }

        [JsonProperty("tax_lines")]
        public List<TaxLine> TAX_LINES { get; set; }

        [JsonProperty("applied_discount")]
        public AppliedDiscount APPLIED_DISCOUNT { get; set; }
    }
}
