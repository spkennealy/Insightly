using Newtonsoft.Json;

namespace Models.Submittable
{
    public class Submitter
    {
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string USER_ID { get; set; }

        [JsonProperty("first_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FIRST_NAME { get; set; }

        [JsonProperty("middle_initial", NullValueHandling = NullValueHandling.Ignore)]
        public string MIDDLE_INITIAL { get; set; }

        [JsonProperty("last_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LAST_NAME { get; set; }

        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string EMAIL { get; set; }

        [JsonProperty("address1", NullValueHandling = NullValueHandling.Ignore)]
        public string ADDRESS_1 { get; set; }

        [JsonProperty("address2", NullValueHandling = NullValueHandling.Ignore)]
        public string ADDRESS_2 { get; set; }

        [JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)]
        public string CITY { get; set; }

        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string STATE { get; set; }

        [JsonProperty("postal_code", NullValueHandling = NullValueHandling.Ignore)]
        public string POSTAL_CODE { get; set; }

        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public string COUNTRY { get; set; }

        [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
        public string PHONE { get; set; }
    }
}
