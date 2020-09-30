using System;
using Newtonsoft.Json;

namespace Models.Insightly
{
    public class InsightlyTask : InsightlyCustomFieldObject
    {
        [JsonProperty("TASK_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? TASK_ID { get; set; }

        [JsonProperty("TITLE", NullValueHandling = NullValueHandling.Ignore)]
        public string TITLE { get; set; }

        [JsonProperty("CATEGORY_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? CATEGORY_ID { get; set; }

        [JsonProperty("DUE_DATE", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DUE_DATE { get; set; }

        [JsonProperty("DATE_CREATED_UTC", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DATE_CREATED_UTC { get; set; }

        [JsonProperty("COMPLETED_DATE_UTC", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? COMPLETED_DATE_UTC { get; set; }

        [JsonProperty("COMPLETED", NullValueHandling = NullValueHandling.Ignore)]
        public bool COMPLETED { get; set; }

        [JsonProperty("DETAILS", NullValueHandling = NullValueHandling.Ignore)]
        public string DETAILS { get; set; }

        [JsonProperty("STATUS", NullValueHandling = NullValueHandling.Ignore)]
        public string STATUS { get; set; }

        [JsonProperty("PRIORITY", NullValueHandling = NullValueHandling.Ignore)]
        public long? PRIORITY { get; set; }

        [JsonProperty("PERCENT_COMPLETE", NullValueHandling = NullValueHandling.Ignore)]
        public long? PERCENT_COMPLETE { get; set; }

        [JsonProperty("START_DATE", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? START_DATE { get; set; }

        [JsonProperty("MILESTONE_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? MILESTONE_ID { get; set; }

        [JsonProperty("RESPONSIBLE_USER_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? RESPONSIBLE_USER_ID { get; set; }

        [JsonProperty("OWNER_USER_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? OWNER_USER_ID { get; set; }

        [JsonProperty("ASSIGNED_BY_USER_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? ASSIGNED_BY_USER_ID { get; set; }

        [JsonProperty("EMAIL_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? EMAIL_ID { get; set; }

        [JsonProperty("PROJECT_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? PROJECT_ID { get; set; }

        [JsonProperty("REMINDER_DATE_UTC", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? REMINDER_DATE_UTC { get; set; }

        [JsonProperty("PARENT_TASK_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? PARENT_TASK_ID { get; set; }

        [JsonProperty("RECURRENCE", NullValueHandling = NullValueHandling.Ignore)]
        public string RECURRENCE { get; set; }

        [JsonProperty("OPPORTUNITY_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? OPPORTUNITY_ID { get; set; }

        [JsonProperty("STAGE_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? STAGE_ID { get; set; }

        [JsonProperty("ASSIGNED_TEAM_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? ASSIGNED_TEAM_ID { get; set; }
    }
}
