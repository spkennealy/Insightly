using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Models.Shopify
{
    public class DraftOrder
    {
        [JsonProperty("id")]
        public long? ID { get; set; }

        [JsonProperty("name")]
        public string NAME { get; set; }

        [JsonProperty("customer")]
        public Customer CUSTOMER { get; set; }

        [JsonProperty("shipping_address")]
        public Address SHIPPING_ADDRESS { get; set; }

        [JsonProperty("billing_address")]
        public Address BILLING_ADDRESS { get; set; }

        [JsonProperty("note")]
        public string NOTE { get; set; }

        [JsonProperty("note_attributes")]
        public List<Obj> NOTE_ATTRIBUTES { get; set; }

        [JsonProperty("email")]
        public string EMAIL { get; set; }

        [JsonProperty("currency")]
        public string CURRENCY { get; set; }

        [JsonProperty("invoice_sent_at")]
        public DateTime? INVOICE_SENT_AT { get; set; }

        [JsonProperty("invoice_url")]
        public string INVOICE_URL { get; set; }

        [JsonProperty("line_items")]
        public List<LineItem> LINE_ITEMS { get; set; }

        [JsonProperty("shipping_line")]
        public ShippingLine SHIPPING_LINE { get; set; }

        [JsonProperty("tags")]
        public string TAGS { get; set; }

        [JsonProperty("tax_exempt")]
        public bool TAX_EXEMPT { get; set; }

        [JsonProperty("tax_exemptions")]
        public List<string> TAX_EXEMPTIONS { get; set; }

        [JsonProperty("tax_lines")]
        public List<TaxLine> TAX_LINES { get; set; }

        [JsonProperty("applied_discount")]
        public List<AppliedDiscount> APPLIED_DISCOUNT { get; set; }

        [JsonProperty("taxes_included")]
        public bool TAXES_INCLUDED { get; set; }

        [JsonProperty("total_tax")]
        public string TOTAL_TAX { get; set; }

        [JsonProperty("subtotal_price")]
        public double? SUBTOTAL_PRICE { get; set; }

        [JsonProperty("total_price")]
        public string TOTAL_PRICE { get; set; }

        [JsonProperty("completed_at")]
        public DateTime? COMPLETED_AT { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CREATED_AT { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UPDATED_AT { get; set; }

        [JsonProperty("status")]
        public string STATUS { get; set; }

        [JsonProperty("order_id")]
        public long? ORDER_ID { get; set; }
    }
}
