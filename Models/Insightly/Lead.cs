using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Models.Insightly
{
    public class Lead : InsightlyCustomFieldObject
    {
        [JsonProperty("LEAD_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? LEAD_ID { get; set; }

        [JsonProperty("SALUTATION", NullValueHandling = NullValueHandling.Ignore)]
        public string SALUTATION { get; set; }

        [JsonProperty("FIRST_NAME", NullValueHandling = NullValueHandling.Ignore)]
        public string FIRST_NAME { get; set; }

        [JsonProperty("LAST_NAME", NullValueHandling = NullValueHandling.Ignore)]
        public string LAST_NAME { get; set; }

        [JsonProperty("LEAD_SOURCE_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? LEAD_SOURCE_ID { get; set; }

        [JsonProperty("LEAD_STATUS_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? LEAD_STATUS_ID { get; set; }

        [JsonProperty("TITLE", NullValueHandling = NullValueHandling.Ignore)]
        public string TITLE { get; set; }

        [JsonProperty("CONVERTED", NullValueHandling = NullValueHandling.Ignore)]
        public bool CONVERTED { get; set; }

        [JsonProperty("CONVERTED_CONTACT_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? CONVERTED_CONTACT_ID { get; set; }

        [JsonProperty("CONVERTED_DATE_UTC", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CONVERTED_DATE_UTC { get; set; }

        [JsonProperty("CONVERTED_OPPORTUNITY_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? CONVERTED_OPPORTUNITY_ID { get; set; }

        [JsonProperty("CONVERTED_ORGANISATION_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? CONVERTED_ORGANISATION_ID { get; set; }

        [JsonProperty("DATE_CREATED_UTC", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DATE_CREATED_UTC { get; set; }

        [JsonProperty("DATE_UPDATED_UTC", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DATE_UPDATED_UTC { get; set; }

        [JsonProperty("EMAIL", NullValueHandling = NullValueHandling.Ignore)]
        public string EMAIL { get; set; }

        [JsonProperty("EMPLOYEE_COUNT", NullValueHandling = NullValueHandling.Ignore)]
        public int? EMPLOYEE_COUNT { get; set; }

        [JsonProperty("FAX", NullValueHandling = NullValueHandling.Ignore)]
        public string FAX { get; set; }

        [JsonProperty("INDUSTRY", NullValueHandling = NullValueHandling.Ignore)]
        public string INDUSTRY { get; set; }

        [JsonProperty("LEAD_DESCRIPTION", NullValueHandling = NullValueHandling.Ignore)]
        public string LEAD_DESCRIPTION { get; set; }

        [JsonProperty("LEAD_RATING", NullValueHandling = NullValueHandling.Ignore)]
        public int? LEAD_RATING { get; set; }

        [JsonProperty("MOBILE", NullValueHandling = NullValueHandling.Ignore)]
        public string MOBILE { get; set; }

        [JsonProperty("OWNER_USER_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? OWNER_USER_ID { get; set; }

        [JsonProperty("PHONE", NullValueHandling = NullValueHandling.Ignore)]
        public string PHONE { get; set; }

        [JsonProperty("RESPONSIBLE_USER_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? RESPONSIBLE_USER_ID { get; set; }

        [JsonProperty("WEBSITE", NullValueHandling = NullValueHandling.Ignore)]
        public string WEBSITE { get; set; }

        [JsonProperty("ADDRESS_STREET", NullValueHandling = NullValueHandling.Ignore)]
        public string ADDRESS_STREET { get; set; }

        [JsonProperty("ADDRESS_CITY", NullValueHandling = NullValueHandling.Ignore)]
        public string ADDRESS_CITY { get; set; }

        [JsonProperty("ADDRESS_STATE", NullValueHandling = NullValueHandling.Ignore)]
        public string ADDRESS_STATE { get; set; }

        [JsonProperty("ADDRESS_POSTCODE", NullValueHandling = NullValueHandling.Ignore)]
        public string ADDRESS_POSTCODE { get; set; }

        [JsonProperty("ADDRESS_COUNTRY", NullValueHandling = NullValueHandling.Ignore)]
        public string ADDRESS_COUNTRY { get; set; }

        [JsonProperty("LAST_ACTIVITY_DATE_UTC", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LAST_ACTIVITY_DATE_UTC { get; set; }

        [JsonProperty("NEXT_ACTIVITY_DATE_UTC", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? NEXT_ACTIVITY_DATE_UTC { get; set; }

        [JsonProperty("ORGANISATION_NAME", NullValueHandling = NullValueHandling.Ignore)]
        public string ORGANISATION_NAME { get; set; }

        [JsonProperty("CREATED_USER_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? CREATED_USER_ID { get; set; }

        [JsonProperty("IMAGE_URL", NullValueHandling = NullValueHandling.Ignore)]
        public string IMAGE_URL { get; set; }

        [JsonProperty("EMAIL_OPTED_OUT", NullValueHandling = NullValueHandling.Ignore)]
        public bool EMAIL_OPTED_OUT { get; set; }

        [JsonProperty("TAGS", NullValueHandling = NullValueHandling.Ignore)]
        public List<Tag> TAGS { get; set; }
    }
}
