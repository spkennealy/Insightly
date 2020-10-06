using Newtonsoft.Json;

namespace Models.Insightly.CustomFieldDetails
{
    public class CustomFieldOption
    {
        [JsonProperty("OPTION_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? OPTION_ID { get; set; }

        [JsonProperty("OPTION_VALUE", NullValueHandling = NullValueHandling.Ignore)]
        public string OPTION_VALUE { get; set; }

        [JsonProperty("OPTION_DEFAULT", NullValueHandling = NullValueHandling.Ignore)]
        public bool OPTION_DEFAULT { get; set; }
    }
}
