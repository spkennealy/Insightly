using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Models.Insightly
{
    public class Opportunity : InsightlyCustomFieldObject
    {
        [JsonProperty("OPPORTUNITY_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? OPPORTUNITY_ID { get; set; }

        [JsonProperty("OPPORTUNITY_NAME", NullValueHandling = NullValueHandling.Ignore)]
        public string OPPORTUNITY_NAME { get; set; }

        [JsonProperty("OPPORTUNITY_DETAILS", NullValueHandling = NullValueHandling.Ignore)]
        public string OPPORTUNITY_DETAILS { get; set; }

        [JsonProperty("OPPORTUNITY_STATE", NullValueHandling = NullValueHandling.Ignore)]
        public string OPPORTUNITY_STATE { get; set; }

        [JsonProperty("RESPONSIBLE_USER_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? RESPONSIBLE_USER_ID { get; set; }

        [JsonProperty("CATEGORY_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? CATEGORY_ID { get; set; }

        [JsonProperty("IMAGE_URL", NullValueHandling = NullValueHandling.Ignore)]
        public string IMAGE_URL { get; set; }

        [JsonProperty("BID_CURRENCY", NullValueHandling = NullValueHandling.Ignore)]
        public string BID_CURRENCY { get; set; }

        [JsonProperty("BID_AMOUNT", NullValueHandling = NullValueHandling.Ignore)]
        public double? BID_AMOUNT { get; set; }

        [JsonProperty("BID_TYPE", NullValueHandling = NullValueHandling.Ignore)]
        public string BID_TYPE { get; set; }

        [JsonProperty("BID_DURATION", NullValueHandling = NullValueHandling.Ignore)]
        public string BID_DURATION { get; set; }

        [JsonProperty("ACTUAL_CLOSE_DATE", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ACTUAL_CLOSE_DATE { get; set; }

        [JsonProperty("DATE_CREATED_UTC", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DATE_CREATED_UTC { get; set; }

        [JsonProperty("DATE_UPDATED_UTC", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DATE_UPDATED_UTC { get; set; }

        [JsonProperty("OPPORTUNITY_VALUE", NullValueHandling = NullValueHandling.Ignore)]
        public long? OPPORTUNITY_VALUE { get; set; }

        [JsonProperty("PROBABILITY", NullValueHandling = NullValueHandling.Ignore)]
        public long? PROBABILITY { get; set; }

        [JsonProperty("FORECAST_CLOSE_DATE", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FORECAST_CLOSE_DATE { get; set; }

        [JsonProperty("OWNER_USER_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? OWNER_USER_ID { get; set; }

        [JsonProperty("LAST_ACTIVITY_DATE_UTC", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LAST_ACTIVITY_DATE_UTC { get; set; }

        [JsonProperty("NEXT_ACTIVITY_DATE_UTC", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? NEXT_ACTIVITY_DATE_UTC { get; set; }

        [JsonProperty("PIPELINE_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? PIPELINE_ID { get; set; }

        [JsonProperty("STAGE_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? STAGE_ID { get; set; }

        [JsonProperty("CREATED_USER_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? CREATED_USER_ID { get; set; }

        [JsonProperty("ORGANISATION_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? ORGANISATION_ID { get; set; }

        [JsonProperty("PRICEBOOK_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? PRICEBOOK_ID { get; set; }

        [JsonProperty("TAGS", NullValueHandling = NullValueHandling.Ignore)]
        public List<Tag> TAGS { get; set; }
    }
}
