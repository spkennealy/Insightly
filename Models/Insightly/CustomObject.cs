using Newtonsoft.Json;
using System;

namespace Models.Insightly
{
    public class CustomObject : InsightlyCustomFieldObject
    {
        [JsonProperty("RECORD_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? RECORD_ID { get; set; }

        [JsonProperty("RECORD_NAME", NullValueHandling = NullValueHandling.Ignore)]
        public string RECORD_NAME { get; set; }

        [JsonProperty("OWNER_USER_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? OWNER_USER_ID { get; set; }

        [JsonProperty("DATE_CREATED_UTC", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DATE_CREATED_UTC { get; set; }

        [JsonProperty("DATE_UPDATED_UTC", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DATE_UPDATED_UTC { get; set; }

        [JsonProperty("CREATED_USER_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? CREATED_USER_ID { get; set; }
    }
}
