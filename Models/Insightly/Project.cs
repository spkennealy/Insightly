using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Models.Insightly
{
    public class Project : InsightlyCustomFieldObject
    {
        [JsonProperty("PROJECT_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? PROJECT_ID { get; set; }

        [JsonProperty("PROJECT_NAME", NullValueHandling = NullValueHandling.Ignore)]
        public string PROJECT_NAME { get; set; }

        [JsonProperty("STATUS", NullValueHandling = NullValueHandling.Ignore)]
        public string STATUS { get; set; }

        [JsonProperty("PROJECT_DETAILS", NullValueHandling = NullValueHandling.Ignore)]
        public string PROJECT_DETAILS { get; set; }

        [JsonProperty("STARTED_DATE", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? STARTED_DATE { get; set; }

        [JsonProperty("COMPLETED_DATE", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? COMPLETED_DATE { get; set; }

        [JsonProperty("OPPORTUNITY_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? OPPORTUNITY_ID { get; set; }

        [JsonProperty("CATEGORY_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? CATEGORY_ID { get; set; }

        [JsonProperty("PIPELINE_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? PIPELINE_ID { get; set; }

        [JsonProperty("STAGE_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? STAGE_ID { get; set; }

        [JsonProperty("IMAGE_URL", NullValueHandling = NullValueHandling.Ignore)]
        public string IMAGE_URL { get; set; }

        [JsonProperty("OWNER_USER_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? OWNER_USER_ID { get; set; }

        [JsonProperty("DATE_CREATED_UTC", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DATE_CREATED_UTC { get; set; }

        [JsonProperty("DATE_UPDATED_UTC", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DATE_UPDATED_UTC { get; set; }

        [JsonProperty("LAST_ACTIVITY_DATE_UTC", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LAST_ACTIVITY_DATE_UTC { get; set; }

        [JsonProperty("NEXT_ACTIVITY_DATE_UTC", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? NEXT_ACTIVITY_DATE_UTC { get; set; }

        [JsonProperty("CREATED_USER_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? CREATED_USER_ID { get; set; }

        [JsonProperty("RESPONSIBLE_USER_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? RESPONSIBLE_USER_ID { get; set; }

        [JsonProperty("TAGS", NullValueHandling = NullValueHandling.Ignore)]
        public List<Tag> TAGS { get; set; }
    }
}
