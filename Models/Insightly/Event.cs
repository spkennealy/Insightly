using Newtonsoft.Json;
using System;

namespace Models.Insightly
{
    public class Event : InsightlyCustomFieldObject
    {
        [JsonProperty("EVENT_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? EVENT_ID { get; set; }

        [JsonProperty("TITLE", NullValueHandling = NullValueHandling.Ignore)]
        public string TITLE { get; set; }

        [JsonProperty("LOCATION", NullValueHandling = NullValueHandling.Ignore)]
        public string LOCATION { get; set; }

        [JsonProperty("START_DATE_UTC", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? START_DATE_UTC { get; set; }

        [JsonProperty("END_DATE_UTC", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? END_DATE_UTC { get; set; }

        [JsonProperty("ALL_DAY", NullValueHandling = NullValueHandling.Ignore)]
        public bool ALL_DAY { get; set; }

        [JsonProperty("DETAILS", NullValueHandling = NullValueHandling.Ignore)]
        public string DETAILS { get; set; }

        [JsonProperty("DATE_CREATED_UTC", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DATE_CREATED_UTC { get; set; }

        [JsonProperty("DATE_UPDATED_UTC", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DATE_UPDATED_UTC { get; set; }

        [JsonProperty("REMINDER_DATE_UTC", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? REMINDER_DATE_UTC { get; set; }

        [JsonProperty("REMINDER_SENT", NullValueHandling = NullValueHandling.Ignore)]
        public bool REMINDER_SENT { get; set; }

        [JsonProperty("OWNER_USER_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? OWNER_USER_ID { get; set; }

        [JsonProperty("PUBLICLY_VISIBLE", NullValueHandling = NullValueHandling.Ignore)]
        public bool PUBLICLY_VISIBLE { get; set; }
    }
}
