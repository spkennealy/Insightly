using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Models.Freshdesk
{
    public class Company : ICustomFieldObject
    {
        [JsonProperty("custom_fields", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, object> CUSTOM_FIELDS { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string DESCRIPTION { get; set; }

        [JsonProperty("domains", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DOMAINS { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? ID { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string NAME { get; set; }

        [JsonProperty("note", NullValueHandling = NullValueHandling.Ignore)]
        public string NOTE { get; set; }

        [JsonProperty("health_score", NullValueHandling = NullValueHandling.Ignore)]
        public string HEALTH_SCORE { get; set; }

        [JsonProperty("account_tier", NullValueHandling = NullValueHandling.Ignore)]
        public string ACCOUNT_TIER { get; set; }

        [JsonProperty("renewal_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? RENEWAL_DATE { get; set; }

        [JsonProperty("industry", NullValueHandling = NullValueHandling.Ignore)]
        public string INDUSTRY { get; set; }

        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CREATED_AT { get; set; }

        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UPDATED_AT { get; set; }
    }
}
