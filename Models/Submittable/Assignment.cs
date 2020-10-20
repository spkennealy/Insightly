using Newtonsoft.Json;

namespace Models.Submittable
{
    public class Assignment
    {
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string USER_ID { get; set; }

        [JsonProperty("staff_name", NullValueHandling = NullValueHandling.Ignore)]
        public string STAFF_NAME { get; set; }

        [JsonProperty("permission_level", NullValueHandling = NullValueHandling.Ignore)]
        public string PERMISSION_LEVEL { get; set; }

        [JsonProperty("permission_value", NullValueHandling = NullValueHandling.Ignore)]
        public int? PERMISSION_VALUE { get; set; }
    }
}
