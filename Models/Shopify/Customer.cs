using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Models.Shopify
{
    public class Customer
    {
        [JsonProperty("id")]
        public long? ID { get; set; }

        [JsonProperty("email")]
        public string EMAIL { get; set; }

        [JsonProperty("accepts_marketing")]
        public bool ACCEPTS_MARKETING { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CREATED_AT { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UPDATED_AT { get; set; }

        [JsonProperty("first_name")]
        public string FIRST_NAME { get; set; }

        [JsonProperty("last_name")]
        public string LAST_NAME { get; set; }

        [JsonProperty("orders_count")]
        public string ORDERS_COUNT { get; set; }

        [JsonProperty("state")]
        public string STATE { get; set; }

        [JsonProperty("total_spent")]
        public string TOTAL_SPENT { get; set; }

        [JsonProperty("last_order_id")]
        public long? LAST_ORDER_ID { get; set; }

        [JsonProperty("note")]
        public string NOTE { get; set; }

        [JsonProperty("verified_email")]
        public bool VERIFIED_EMAIL { get; set; }

        [JsonProperty("multipass_identifier")]
        public string MULTIPASS_IDENTIFIER { get; set; }

        [JsonProperty("tax_exempt")]
        public bool TAX_EXEMPT { get; set; }

        [JsonProperty("tax_exemptions")]
        public List<string> TAX_EXEMPTIONS { get; set; }

        [JsonProperty("phone")]
        public string PHONE { get; set; }

        [JsonProperty("tags")]
        public string TAGS { get; set; }

        [JsonProperty("last_order_name")]
        public string LAST_ORDER_NAME { get; set; }

        [JsonProperty("currency")]
        public string CURRENCY { get; set; }

        [JsonProperty("addresses")]
        public List<Address> ADDRESSES { get; set; }

        [JsonProperty("admin_graphql_api_id")]
        public string ADMIN_GRAPHQL_API_ID { get; set; }

        [JsonProperty("default_address")]
        public Address DEFAULT_ADDRESS { get; set; }
    }
}
