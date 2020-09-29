using System;
using Newtonsoft.Json;

namespace Models.Insightly
{
    public class Product : InsightlyCustomFieldObject
    {
        [JsonProperty("PRODUCT_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? PRODUCT_ID { get; set; }

        [JsonProperty("PRODUCT_NAME", NullValueHandling = NullValueHandling.Ignore)]
        public string PRODUCT_NAME { get; set; }

        [JsonProperty("PRODUCT_CODE", NullValueHandling = NullValueHandling.Ignore)]
        public string PRODUCT_CODE { get; set; }

        [JsonProperty("PRODUCT_SKU", NullValueHandling = NullValueHandling.Ignore)]
        public string PRODUCT_SKU { get; set; }

        [JsonProperty("DESCRIPTION", NullValueHandling = NullValueHandling.Ignore)]
        public string DESCRIPTION { get; set; }

        [JsonProperty("PRODUCT_FAMILY", NullValueHandling = NullValueHandling.Ignore)]
        public string PRODUCT_FAMILY { get; set; }

        [JsonProperty("PRODUCT_IMAGE_URL", NullValueHandling = NullValueHandling.Ignore)]
        public string PRODUCT_IMAGE_URL { get; set; }

        [JsonProperty("CURRENCY_CODE", NullValueHandling = NullValueHandling.Ignore)]
        public string CURRENCY_CODE { get; set; }

        [JsonProperty("DEFAULT_PRICE", NullValueHandling = NullValueHandling.Ignore)]
        public double? DEFAULT_PRICE { get; set; }

        [JsonProperty("DATE_CREATED_UTC", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DATE_CREATED_UTC { get; set; }

        [JsonProperty("DATE_UPDATED_UTC", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DATE_UPDATED_UTC { get; set; }

        [JsonProperty("CREATED_USER_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? CREATED_USER_ID { get; set; }

        [JsonProperty("OWNER_USER_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? OWNER_USER_ID { get; set; }

        [JsonProperty("ACTIVE", NullValueHandling = NullValueHandling.Ignore)]
        public bool ACTIVE { get; set; }
    }
}
