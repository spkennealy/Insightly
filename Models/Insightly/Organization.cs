using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Models.Insightly
{
    public class Organization : InsightlyCustomFieldObject
    {
        [JsonProperty("ORGANISATION_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? ORGANISATION_ID { get; set; }

        [JsonProperty("ORGANISATION_NAME", NullValueHandling = NullValueHandling.Ignore)]
        public string ORGANISATION_NAME { get; set; }

        [JsonProperty("BACKGROUND", NullValueHandling = NullValueHandling.Ignore)]
        public string BACKGROUND { get; set; }

        [JsonProperty("IMAGE_URL", NullValueHandling = NullValueHandling.Ignore)]
        public string IMAGE_URL { get; set; }

        [JsonProperty("OWNER_USER_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? OWNER_USER_ID { get; set; }

        [JsonProperty("DATE_CREATED_UTC", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DATE_CREATED_UTC { get; set; }

        [JsonProperty("DATE_UPDATED_UTC", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DATE_UPDATED_UTC { get; set; }

        [JsonProperty("LAST_ACTIVITY_DATE_UTC", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LAST_ACTIVITY_DATE_UTC { get; set; }

        [JsonProperty("NEXT_ACTIVITY_DATE_UTC", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? NEXT_ACTIVITY_DATE_UTC { get; set; }

        [JsonProperty("CREATED_USER_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? CREATED_USER_ID { get; set; }

        [JsonProperty("PHONE", NullValueHandling = NullValueHandling.Ignore)]
        public string PHONE { get; set; }

        [JsonProperty("PHONE_FAX", NullValueHandling = NullValueHandling.Ignore)]
        public string PHONE_FAX { get; set; }

        [JsonProperty("WEBSITE", NullValueHandling = NullValueHandling.Ignore)]
        public string WEBSITE { get; set; }

        [JsonProperty("ADDRESS_BILLING_STREET", NullValueHandling = NullValueHandling.Ignore)]
        public string ADDRESS_BILLING_STREET { get; set; }

        [JsonProperty("ADDRESS_BILLING_CITY", NullValueHandling = NullValueHandling.Ignore)]
        public string ADDRESS_BILLING_CITY { get; set; }

        [JsonProperty("ADDRESS_BILLING_STATE", NullValueHandling = NullValueHandling.Ignore)]
        public string ADDRESS_BILLING_STATE { get; set; }

        [JsonProperty("ADDRESS_BILLING_POSTCODE", NullValueHandling = NullValueHandling.Ignore)]
        public string ADDRESS_BILLING_POSTCODE { get; set; }

        [JsonProperty("ADDRESS_BILLING_COUNTRY", NullValueHandling = NullValueHandling.Ignore)]
        public string ADDRESS_BILLING_COUNTRY { get; set; }

        [JsonProperty("ADDRESS_SHIP_STREET", NullValueHandling = NullValueHandling.Ignore)]
        public string ADDRESS_SHIP_STREET { get; set; }

        [JsonProperty("ADDRESS_SHIP_CITY", NullValueHandling = NullValueHandling.Ignore)]
        public string ADDRESS_SHIP_CITY { get; set; }

        [JsonProperty("ADDRESS_SHIP_STATE", NullValueHandling = NullValueHandling.Ignore)]
        public string ADDRESS_SHIP_STATE { get; set; }

        [JsonProperty("ADDRESS_SHIP_POSTCODE", NullValueHandling = NullValueHandling.Ignore)]
        public string ADDRESS_SHIP_POSTCODE { get; set; }

        [JsonProperty("ADDRESS_SHIP_COUNTRY", NullValueHandling = NullValueHandling.Ignore)]
        public string ADDRESS_SHIP_COUNTRY { get; set; }

        [JsonProperty("SOCIAL_LINKEDIN", NullValueHandling = NullValueHandling.Ignore)]
        public string SOCIAL_LINKEDIN { get; set; }

        [JsonProperty("SOCIAL_FACEBOOK", NullValueHandling = NullValueHandling.Ignore)]
        public string SOCIAL_FACEBOOK { get; set; }

        [JsonProperty("SOCIAL_TWITTER", NullValueHandling = NullValueHandling.Ignore)]
        public string SOCIAL_TWITTER { get; set; }

        [JsonProperty("TAGS", NullValueHandling = NullValueHandling.Ignore)]
        public List<Tag> TAGS { get; set; }

        [JsonProperty("DATES", NullValueHandling = NullValueHandling.Ignore)]
        public List<Date> DATES { get; set; }

        [JsonProperty("EMAILDOMAINS", NullValueHandling = NullValueHandling.Ignore)]
        public List<EmailDomain> EMAILDOMAINS { get; set; }
    }
}