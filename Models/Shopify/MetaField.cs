using System;
using Newtonsoft.Json;

namespace Models.Shopify
{
    public class Metafield
    {
        [JsonProperty("created_at")]
        public DateTime? CREATED_AT { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UPDATED_AT { get; set; }

        [JsonProperty("description")]
        public string DESCRIPTION { get; set; }

        [JsonProperty("id")]
        public long? ID { get; set; }

        [JsonProperty("key")]
        public string KEY { get; set; }

        [JsonProperty("namespace")]
        public string NAMESPACE { get; set; }

        [JsonProperty("owner_id")]
        public long? OWNER_ID { get; set; }

        [JsonProperty("owner_resource")]
        public string OWNER_RESOURCE { get; set; }

        [JsonProperty("value")]
        public object VALUE { get; set; }

        [JsonProperty("value_type")]
        public string VALUE_TYPE { get; set; }

        [JsonProperty("admin_graphql_api_id")]
        public string ADMIN_GRAPHQL_API_ID { get; set; }
    }
}
