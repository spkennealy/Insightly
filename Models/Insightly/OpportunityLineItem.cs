using System;
using Newtonsoft.Json;

namespace Models.Insightly
{
    public class OpportunityLineItem : InsightlyCustomFieldObject
    {
        [JsonProperty("OPPORTUNITY_ITEM_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? OPPORTUNITY_ITEM_ID { get; set; }

        [JsonProperty("OPPORTUNITY_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? OPPORTUNITY_ID { get; set; }

        [JsonProperty("PRICEBOOK_ENTRY_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? PRICEBOOK_ENTRY_ID { get; set; }

        [JsonProperty("CURRENCY_CODE", NullValueHandling = NullValueHandling.Ignore)]
        public string CURRENCY_CODE { get; set; }

        [JsonProperty("UNIT_PRICE", NullValueHandling = NullValueHandling.Ignore)]
        public double? UNIT_PRICE { get; set; }

        [JsonProperty("DESCRIPTION", NullValueHandling = NullValueHandling.Ignore)]
        public string DESCRIPTION { get; set; }

        [JsonProperty("QUANTITY", NullValueHandling = NullValueHandling.Ignore)]
        public double? QUANTITY { get; set; }

        [JsonProperty("SERVICE_DATE", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? SERVICE_DATE { get; set; }

        [JsonProperty("TOTAL_PRICE", NullValueHandling = NullValueHandling.Ignore)]
        public double? TOTAL_PRICE { get; set; }

        [JsonProperty("DATE_CREATED_UTC", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DATE_CREATED_UTC { get; set; }

        [JsonProperty("DATE_UPDATED_UTC", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DATE_UPDATED_UTC { get; set; }

        [JsonProperty("LIST_PRICE", NullValueHandling = NullValueHandling.Ignore)]
        public double? LIST_PRICE { get; set; }

        [JsonProperty("SUBTOTAL", NullValueHandling = NullValueHandling.Ignore)]
        public double? SUBTOTAL { get; set; }

        [JsonProperty("DISCOUNT", NullValueHandling = NullValueHandling.Ignore)]
        public double? DISCOUNT { get; set; }
    }
}
