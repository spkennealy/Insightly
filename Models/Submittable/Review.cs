using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Models.Submittable
{
    public class Review
    {
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string USER_ID { get; set; }

        [JsonProperty("staff_name", NullValueHandling = NullValueHandling.Ignore)]
        public string STAFF_NAME { get; set; }

        [JsonProperty("is_finalized", NullValueHandling = NullValueHandling.Ignore)]
        public bool IS_FINALIZED { get; set; }

        [JsonProperty("finalized_on_utc", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FINALIZED_ON_UTC { get; set; }

        [JsonProperty("score", NullValueHandling = NullValueHandling.Ignore)]
        public int? SCORE { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<ReviewField> ITEMS { get; set; }
    }
}
