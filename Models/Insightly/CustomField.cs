using Newtonsoft.Json;

namespace Models.Insightly
{
    public class CustomField
    {
        [JsonProperty("FIELD_NAME", NullValueHandling = NullValueHandling.Ignore)]
        public string FIELD_NAME { get; set; }

        [JsonProperty("FIELD_VALUE", NullValueHandling = NullValueHandling.Ignore)]
        public object FIELD_VALUE { get; set; }

        [JsonProperty("CUSTOM_FIELD_ID", NullValueHandling = NullValueHandling.Ignore)]
        public string CUSTOM_FIELD_ID { get; set; }
    }
}
