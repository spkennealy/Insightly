using System;
using Newtonsoft.Json;

namespace Models.Insightly
{
    public class PricebookEntry : InsightlyCustomFieldObject
    {
        [JsonProperty("PRICEBOOK_ENTRY_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? PRICEBOOK_ENTRY_ID { get; set; }

        [JsonProperty("PRICEBOOK_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? PRICEBOOK_ID { get; set; }

        [JsonProperty("PRODUCT_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? PRODUCT_ID { get; set; }

        [JsonProperty("CURRENCY_CODE", NullValueHandling = NullValueHandling.Ignore)]
        public string CURRENCY_CODE { get; set; }

        [JsonProperty("PRICE", NullValueHandling = NullValueHandling.Ignore)]
        public double? PRICE { get; set; }

        [JsonProperty("USE_STANDARD_PRICE", NullValueHandling = NullValueHandling.Ignore)]
        public bool USE_STANDARD_PRICE { get; set; }

        [JsonProperty("ACTIVE", NullValueHandling = NullValueHandling.Ignore)]
        public bool ACTIVE { get; set; }

        [JsonProperty("CREATED_USER_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? CREATED_USER_ID { get; set; }

        [JsonProperty("DATE_CREATED_UTC", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DATE_CREATED_UTC { get; set; }

        [JsonProperty("DATE_UPDATED_UTC", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DATE_UPDATED_UTC { get; set; }
    }
}
