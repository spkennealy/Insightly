using System;
using Newtonsoft.Json;

namespace Models.Insightly
{
    public class Quote : InsightlyCustomFieldObject
    {
        [JsonProperty("QUOTE_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? QUOTE_ID { get; set; }

        [JsonProperty("QUOTATION_NAME", NullValueHandling = NullValueHandling.Ignore)]
        public string QUOTATION_NAME { get; set; }

        [JsonProperty("OPPORTUNITY_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? OPPORTUNITY_ID { get; set; }

        [JsonProperty("CONTACT_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? CONTACT_ID { get; set; }

        [JsonProperty("ORGANISATION_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? ORGANISATION_ID { get; set; }

        [JsonProperty("PRICEBOOK_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? PRICEBOOK_ID { get; set; }

        [JsonProperty("QUOTATION_NUMBER", NullValueHandling = NullValueHandling.Ignore)]
        public string QUOTATION_NUMBER { get; set; }

        [JsonProperty("QUOTATION_DESCRIPTION", NullValueHandling = NullValueHandling.Ignore)]
        public string QUOTATION_DESCRIPTION { get; set; }

        [JsonProperty("QUOTATION_PHONE", NullValueHandling = NullValueHandling.Ignore)]
        public string QUOTATION_PHONE { get; set; }

        [JsonProperty("QUOTATION_EMAIL", NullValueHandling = NullValueHandling.Ignore)]
        public string QUOTATION_EMAIL { get; set; }

        [JsonProperty("QUOTATION_FAX", NullValueHandling = NullValueHandling.Ignore)]
        public string QUOTATION_FAX { get; set; }

        [JsonProperty("QUOTE_STATUS", NullValueHandling = NullValueHandling.Ignore)]
        public string QUOTE_STATUS { get; set; }

        [JsonProperty("QUOTATION_EXPIRATION_DATE", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? QUOTATION_EXPIRATION_DATE { get; set; }

        [JsonProperty("LINE_ITEM_COUNT", NullValueHandling = NullValueHandling.Ignore)]
        public int? LINE_ITEM_COUNT { get; set; }

        [JsonProperty("QUOTATION_CURRENCY_CODE", NullValueHandling = NullValueHandling.Ignore)]
        public string QUOTATION_CURRENCY_CODE { get; set; }

        [JsonProperty("SUBTOTAL", NullValueHandling = NullValueHandling.Ignore)]
        public double? SUBTOTAL { get; set; }

        [JsonProperty("DISCOUNT", NullValueHandling = NullValueHandling.Ignore)]
        public double? DISCOUNT { get; set; }

        [JsonProperty("TOTAL_PRICE", NullValueHandling = NullValueHandling.Ignore)]
        public double? TOTAL_PRICE { get; set; }

        [JsonProperty("SHIPPING_HANDLING", NullValueHandling = NullValueHandling.Ignore)]
        public double? SHIPPING_HANDLING { get; set; }

        [JsonProperty("TAX", NullValueHandling = NullValueHandling.Ignore)]
        public double? TAX { get; set; }

        [JsonProperty("GRAND_TOTAL", NullValueHandling = NullValueHandling.Ignore)]
        public double? GRAND_TOTAL { get; set; }

        [JsonProperty("ADDRESS_BILLING_NAME", NullValueHandling = NullValueHandling.Ignore)]
        public string ADDRESS_BILLING_NAME { get; set; }

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

        [JsonProperty("ADDRESS_SHIPPING_NAME", NullValueHandling = NullValueHandling.Ignore)]
        public string ADDRESS_SHIPPING_NAME { get; set; }

        [JsonProperty("ADDRESS_SHIPPING_STREET", NullValueHandling = NullValueHandling.Ignore)]
        public string ADDRESS_SHIPPING_STREET { get; set; }

        [JsonProperty("ADDRESS_SHIPPING_CITY", NullValueHandling = NullValueHandling.Ignore)]
        public string ADDRESS_SHIPPING_CITY { get; set; }

        [JsonProperty("ADDRESS_SHIPPING_STATE", NullValueHandling = NullValueHandling.Ignore)]
        public string ADDRESS_SHIPPING_STATE { get; set; }

        [JsonProperty("ADDRESS_SHIPPING_POSTCODE", NullValueHandling = NullValueHandling.Ignore)]
        public string ADDRESS_SHIPPING_POSTCODE { get; set; }

        [JsonProperty("ADDRESS_SHIPPING_COUNTRY", NullValueHandling = NullValueHandling.Ignore)]
        public string ADDRESS_SHIPPING_COUNTRY { get; set; }

        [JsonProperty("OWNER_USER_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? OWNER_USER_ID { get; set; }

        [JsonProperty("DATE_CREATED_UTC", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DATE_CREATED_UTC { get; set; }

        [JsonProperty("DATE_UPDATED_UTC", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DATE_UPDATED_UTC { get; set; }

        [JsonProperty("CREATED_USER_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? CREATED_USER_ID { get; set; }

    }
}
