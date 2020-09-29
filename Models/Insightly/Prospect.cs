using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Models.Insightly
{
    public class Prospect : InsightlyCustomFieldObject
    {
        [JsonProperty("PROSPECT_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? PROSPECT_ID { get; set; }

        [JsonProperty("LEAD_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? LEAD_ID { get; set; }

        [JsonProperty("CONTACT_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? CONTACT_ID { get; set; }

        [JsonProperty("ORGANISATION_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? ORGANISATION_ID { get; set; }

        [JsonProperty("SALUTATION", NullValueHandling = NullValueHandling.Ignore)]
        public string SALUTATION { get; set; }

        [JsonProperty("FIRST_NAME", NullValueHandling = NullValueHandling.Ignore)]
        public string FIRST_NAME { get; set; }

        [JsonProperty("LAST_NAME", NullValueHandling = NullValueHandling.Ignore)]
        public string LAST_NAME { get; set; }

        [JsonProperty("ORGANISATION_NAME", NullValueHandling = NullValueHandling.Ignore)]
        public string ORGANISATION_NAME { get; set; }

        [JsonProperty("TITLE", NullValueHandling = NullValueHandling.Ignore)]
        public string TITLE { get; set; }

        [JsonProperty("EMAIL_ADDRESS", NullValueHandling = NullValueHandling.Ignore)]
        public string EMAIL_ADDRESS { get; set; }

        [JsonProperty("PHONE", NullValueHandling = NullValueHandling.Ignore)]
        public string PHONE { get; set; }

        [JsonProperty("MOBILE", NullValueHandling = NullValueHandling.Ignore)]
        public string MOBILE { get; set; }

        [JsonProperty("FAX", NullValueHandling = NullValueHandling.Ignore)]
        public string FAX { get; set; }

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

        [JsonProperty("INDUSTRY", NullValueHandling = NullValueHandling.Ignore)]
        public string INDUSTRY { get; set; }

        [JsonProperty("EMPLOYEE_COUNT", NullValueHandling = NullValueHandling.Ignore)]
        public int? EMPLOYEE_COUNT { get; set; }

        [JsonProperty("SCORE", NullValueHandling = NullValueHandling.Ignore)]
        public int? SCORE { get; set; }

        [JsonProperty("DESCRIPTION", NullValueHandling = NullValueHandling.Ignore)]
        public string DESCRIPTION { get; set; }

        [JsonProperty("DO_NOT_EMAIL", NullValueHandling = NullValueHandling.Ignore)]
        public bool DO_NOT_EMAIL { get; set; }

        [JsonProperty("DO_NOT_CALL", NullValueHandling = NullValueHandling.Ignore)]
        public bool DO_NOT_CALL { get; set; }

        [JsonProperty("OPTED_OUT", NullValueHandling = NullValueHandling.Ignore)]
        public bool OPTED_OUT { get; set; }

        [JsonProperty("LAST_ACTIVITY_DATE_UTC", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LAST_ACTIVITY_DATE_UTC { get; set; }

        [JsonProperty("CREATED_USER_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? CREATED_USER_ID { get; set; }

        [JsonProperty("OWNER_USER_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? OWNER_USER_ID { get; set; }

        [JsonProperty("DATE_CREATED_UTC", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DATE_CREATED_UTC { get; set; }

        [JsonProperty("DATE_UPDATED_UTC", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DATE_UPDATED_UTC { get; set; }

        [JsonProperty("DO_NOT_SYNC", NullValueHandling = NullValueHandling.Ignore)]
        public bool DO_NOT_SYNC { get; set; }

        [JsonProperty("LEAD_CONVERSION_DATE_UTC", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LEAD_CONVERSION_DATE_UTC { get; set; }

        [JsonProperty("TAGS", NullValueHandling = NullValueHandling.Ignore)]
        public List<Tag> TAGS { get; set; }
    }
}
