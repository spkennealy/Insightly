using Newtonsoft.Json;

namespace Models.Insightly
{
    public class Link
    {
        [JsonProperty("RELATIONSHIP_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? RELATIONSHIP_ID { get; set; }

        [JsonProperty("IS_FORWARD", NullValueHandling = NullValueHandling.Ignore)]
        public bool IS_FORWARD { get; set; }

        [JsonProperty("DETAILS", NullValueHandling = NullValueHandling.Ignore)]
        public string DETAILS { get; set; }

        [JsonProperty("ROLE", NullValueHandling = NullValueHandling.Ignore)]
        public string ROLE { get; set; }

        [JsonProperty("LINK_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? LINK_ID { get; set; }

        [JsonProperty("OBJECT_NAME", NullValueHandling = NullValueHandling.Ignore)]
        public string OBJECT_NAME { get; set; }

        [JsonProperty("OBJECT_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? OBJECT_ID { get; set; }

        [JsonProperty("LINK_OBJECT_NAME", NullValueHandling = NullValueHandling.Ignore)]
        public string LINK_OBJECT_NAME { get; set; }

        [JsonProperty("LINK_OBJECT_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? LINK_OBJECT_ID { get; set; }

    }
}
