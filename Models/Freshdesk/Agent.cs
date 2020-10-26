using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Models.Freshdesk
{
    public class Agent : ICustomFieldObject
    {
        [JsonProperty("available", NullValueHandling = NullValueHandling.Ignore)]
        public bool AVAILABLE { get; set; }

        [JsonProperty("occasional", NullValueHandling = NullValueHandling.Ignore)]
        public bool OCCASIONAL { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? ID { get; set; }

        [JsonProperty("ticket_scope", NullValueHandling = NullValueHandling.Ignore)]
        public int? TICKET_SCOPE { get; set; }

        [JsonProperty("signature", NullValueHandling = NullValueHandling.Ignore)]
        public string SIGNATURE { get; set; }

        [JsonProperty("group_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<long?> GROUP_IDS { get; set; }

        [JsonProperty("role_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<long?> ROLE_IDS { get; set; }

        [JsonProperty("skill_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<long?> SKILL_IDS { get; set; }

        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CREATED_AT { get; set; }

        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UPDATED_AT { get; set; }

        [JsonProperty("last_active_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LAST_ACTIVE_AT { get; set; }

        [JsonProperty("available_since", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? AVAILABLE_SINCE { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string TYPE { get; set; }

        [JsonProperty("contact", NullValueHandling = NullValueHandling.Ignore)]
        public Contact CONTACT { get; set; }

        [JsonProperty("custom_fields", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, object> CUSTOM_FIELDS { get; set; }
    }
}
