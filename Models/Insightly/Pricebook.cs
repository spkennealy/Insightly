using System;
using Newtonsoft.Json;

namespace Models.Insightly
{
    public class Pricebook
    {
        [JsonProperty("PRICEBOOK_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? PRICEBOOK_ID { get; set; }

        [JsonProperty("NAME", NullValueHandling = NullValueHandling.Ignore)]
        public string NAME { get; set; }

        [JsonProperty("DESCRIPTION", NullValueHandling = NullValueHandling.Ignore)]
        public string DESCRIPTION { get; set; }

        [JsonProperty("CURRENCY_CODE", NullValueHandling = NullValueHandling.Ignore)]
        public string CURRENCY_CODE { get; set; }

        [JsonProperty("IS_STANDARD", NullValueHandling = NullValueHandling.Ignore)]
        public bool IS_STANDARD { get; set; }

        [JsonProperty("ACTIVE", NullValueHandling = NullValueHandling.Ignore)]
        public bool ACTIVE { get; set; }

        [JsonProperty("OWNER_USER_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? OWNER_USER_ID { get; set; }

        [JsonProperty("CREATED_USER_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? CREATED_USER_ID { get; set; }

        [JsonProperty("DATE_CREATED_UTC", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DATE_CREATED_UTC { get; set; }

        [JsonProperty("DATE_UPDATED_UTC", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DATE_UPDATED_UTC { get; set; }
    }
}
