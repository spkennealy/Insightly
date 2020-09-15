using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Insightly
{
    public class Contact : InsightlyObject
    {
        [JsonProperty("CONTACT_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? CONTACT_ID { get; set; }

        [JsonProperty("SALUTATION", NullValueHandling = NullValueHandling.Ignore)]
        public string SALUTATION { get; set; }

        [JsonProperty("FIRST_NAME", NullValueHandling = NullValueHandling.Ignore)]
        public string FIRST_NAME { get; set; }

        [JsonProperty("LAST_NAME", NullValueHandling = NullValueHandling.Ignore)]
        public string LAST_NAME { get; set; }

        [JsonProperty("IMAGE_URL", NullValueHandling = NullValueHandling.Ignore)]
        public string IMAGE_URL { get; set; }

        [JsonProperty("BACKGROUND", NullValueHandling = NullValueHandling.Ignore)]
        public string BACKGROUND { get; set; }

        [JsonProperty("OWNER_USER_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? OWNER_USER_ID { get; set; }

        [JsonProperty("DATE_CREATED_UTC", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DATE_CREATED_UTC { get; set; }

        [JsonProperty("DATE_UPDATED_UTC", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DATE_UPDATED_UTC { get; set; }

        [JsonProperty("SOCIAL_LINKEDIN", NullValueHandling = NullValueHandling.Ignore)]
        public string SOCIAL_LINKEDIN { get; set; }

        [JsonProperty("SOCIAL_FACEBOOK", NullValueHandling = NullValueHandling.Ignore)]
        public string SOCIAL_FACEBOOK { get; set; }

        [JsonProperty("SOCIAL_TWITTER", NullValueHandling = NullValueHandling.Ignore)]
        public string SOCIAL_TWITTER { get; set; }

        [JsonProperty("DATE_OF_BIRTH", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DATE_OF_BIRTH { get; set; }

        [JsonProperty("PHONE", NullValueHandling = NullValueHandling.Ignore)]
        public string PHONE { get; set; }

        [JsonProperty("PHONE_HOME", NullValueHandling = NullValueHandling.Ignore)]
        public string PHONE_HOME { get; set; }

        [JsonProperty("PHONE_MOBILE", NullValueHandling = NullValueHandling.Ignore)]
        public string PHONE_MOBILE { get; set; }

        [JsonProperty("PHONE_OTHER", NullValueHandling = NullValueHandling.Ignore)]
        public string PHONE_OTHER { get; set; }

        [JsonProperty("PHONE_ASSISTANT", NullValueHandling = NullValueHandling.Ignore)]
        public string PHONE_ASSISTANT { get; set; }

        [JsonProperty("PHONE_FAX", NullValueHandling = NullValueHandling.Ignore)]
        public string PHONE_FAX { get; set; }

        [JsonProperty("EMAIL_ADDRESS", NullValueHandling = NullValueHandling.Ignore)]
        public string EMAIL_ADDRESS { get; set; }

        [JsonProperty("ASSISTANT_NAME", NullValueHandling = NullValueHandling.Ignore)]
        public string ASSISTANT_NAME { get; set; }

        [JsonProperty("ADDRESS_MAIL_STREET", NullValueHandling = NullValueHandling.Ignore)]
        public string ADDRESS_MAIL_STREET { get; set; }

        [JsonProperty("ADDRESS_MAIL_CITY", NullValueHandling = NullValueHandling.Ignore)]
        public string ADDRESS_MAIL_CITY { get; set; }

        [JsonProperty("ADDRESS_MAIL_STATE", NullValueHandling = NullValueHandling.Ignore)]
        public string ADDRESS_MAIL_STATE { get; set; }

        [JsonProperty("ADDRESS_MAIL_POSTCODE", NullValueHandling = NullValueHandling.Ignore)]
        public string ADDRESS_MAIL_POSTCODE { get; set; }

        [JsonProperty("ADDRESS_MAIL_COUNTRY", NullValueHandling = NullValueHandling.Ignore)]
        public string ADDRESS_MAIL_COUNTRY { get; set; }

        [JsonProperty("ADDRESS_OTHER_STREET", NullValueHandling = NullValueHandling.Ignore)]
        public string ADDRESS_OTHER_STREET { get; set; }

        [JsonProperty("ADDRESS_OTHER_CITY", NullValueHandling = NullValueHandling.Ignore)]
        public string ADDRESS_OTHER_CITY { get; set; }

        [JsonProperty("ADDRESS_OTHER_STATE", NullValueHandling = NullValueHandling.Ignore)]
        public string ADDRESS_OTHER_STATE { get; set; }

        [JsonProperty("ADDRESS_OTHER_POSTCODE", NullValueHandling = NullValueHandling.Ignore)]
        public string ADDRESS_OTHER_POSTCODE { get; set; }

        [JsonProperty("ADDRESS_OTHER_COUNTRY", NullValueHandling = NullValueHandling.Ignore)]
        public string ADDRESS_OTHER_COUNTRY { get; set; }

        [JsonProperty("LAST_ACTIVITY_DATE_UTC", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LAST_ACTIVITY_DATE_UTC { get; set; }

        [JsonProperty("NEXT_ACTIVITY_DATE_UTC", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? NEXT_ACTIVITY_DATE_UTC { get; set; }

        [JsonProperty("CREATED_USER_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? CREATED_USER_ID { get; set; }

        [JsonProperty("ORGANISATION_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? ORGANISATION_ID { get; set; }

        [JsonProperty("TITLE", NullValueHandling = NullValueHandling.Ignore)]
        public string TITLE { get; set; }

        [JsonProperty("EMAIL_OPTED_OUT", NullValueHandling = NullValueHandling.Ignore)]
        public bool EMAIL_OPTED_OUT { get; set; }

        [JsonProperty("TAGS", NullValueHandling = NullValueHandling.Ignore)]
        public List<Tag> TAGS { get; set; }

        [JsonProperty("DATES", NullValueHandling = NullValueHandling.Ignore)]
        public List<Date> DATES { get; set; }
    }
}
