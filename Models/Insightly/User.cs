using System;
using Newtonsoft.Json;

namespace Models.Insightly
{
    public class User
    {
        [JsonProperty("USER_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? USER_ID { get; set; }

        [JsonProperty("CONTACT_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? CONTACT_ID { get; set; }

        [JsonProperty("FIRST_NAME", NullValueHandling = NullValueHandling.Ignore)]
        public string FIRST_NAME { get; set; }

        [JsonProperty("LAST_NAME", NullValueHandling = NullValueHandling.Ignore)]
        public string LAST_NAME { get; set; }

        [JsonProperty("TIMEZONE_ID", NullValueHandling = NullValueHandling.Ignore)]
        public string TIMEZONE_ID { get; set; }

        [JsonProperty("EMAIL_ADDRESS", NullValueHandling = NullValueHandling.Ignore)]
        public string EMAIL_ADDRESS { get; set; }

        [JsonProperty("EMAIL_DROPBOX_IDENTIFIER", NullValueHandling = NullValueHandling.Ignore)]
        public string EMAIL_DROPBOX_IDENTIFIER { get; set; }

        [JsonProperty("EMAIL_DROPBOX_ADDRESS", NullValueHandling = NullValueHandling.Ignore)]
        public string EMAIL_DROPBOX_ADDRESS { get; set; }

        [JsonProperty("ADMINISTRATOR", NullValueHandling = NullValueHandling.Ignore)]
        public bool ADMINISTRATOR { get; set; }

        [JsonProperty("ACCOUNT_OWNER", NullValueHandling = NullValueHandling.Ignore)]
        public bool ACCOUNT_OWNER { get; set; }

        [JsonProperty("ACTIVE", NullValueHandling = NullValueHandling.Ignore)]
        public bool ACTIVE { get; set; }

        [JsonProperty("DATE_CREATED_UTC", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DATE_CREATED_UTC { get; set; }

        [JsonProperty("DATE_UPDATED_UTC", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DATE_UPDATED_UTC { get; set; }

        [JsonProperty("USER_CURRENCY", NullValueHandling = NullValueHandling.Ignore)]
        public string USER_CURRENCY { get; set; }

        [JsonProperty("CONTACT_DISPLAY", NullValueHandling = NullValueHandling.Ignore)]
        public string CONTACT_DISPLAY { get; set; }

        [JsonProperty("CONTACT_ORDER", NullValueHandling = NullValueHandling.Ignore)]
        public string CONTACT_ORDER { get; set; }

        [JsonProperty("TASK_WEEK_START", NullValueHandling = NullValueHandling.Ignore)]
        public int? TASK_WEEK_START { get; set; }

        [JsonProperty("INSTANCE_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? INSTANCE_ID { get; set; }

        [JsonProperty("PROFILE_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? PROFILE_ID { get; set; }

        [JsonProperty("ROLE_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? ROLE_ID { get; set; }
    }
}
