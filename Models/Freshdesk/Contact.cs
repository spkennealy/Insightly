using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Models.Freshdesk
{
    public class Contact : ICustomFieldObject
    {
        [JsonProperty("active", NullValueHandling = NullValueHandling.Ignore)]
        public bool ACTIVE { get; set; } = true;

        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string ADDRESS { get; set; }

        [JsonProperty("company_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? COMPANY_ID { get; set; }

        [JsonProperty("custom_fields", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, object> CUSTOM_FIELDS { get; set; } = new Dictionary<string, object>();

        //[JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        //public bool DELETED { get; set; }

        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string EMAIL { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? ID { get; set; }

        [JsonProperty("job_title", NullValueHandling = NullValueHandling.Ignore)]
        public string JOB_TITLE { get; set; }

        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public string LANGUAGE { get; set; }

        [JsonProperty("mobile", NullValueHandling = NullValueHandling.Ignore)]
        public long? MOBILE { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string NAME { get; set; }

        [JsonProperty("other_emails", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> OTHER_EMAILS { get; set; }

        [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
        public string PHONE { get; set; }

        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TAGS { get; set; }

        [JsonProperty("time_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string TIME_ZONE { get; set; }

        [JsonProperty("twitter_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TWITTER_ID { get; set; }

        [JsonProperty("unique_external_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UNIQUE_EXTERNAL_ID { get; set; }

        [JsonProperty("other_companies", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> OTHER_COMPANIES { get; set; }

        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CREATED_AT { get; set; }

        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UPDATED_AT { get; set; }
    }
}
