using Newtonsoft.Json;

namespace Models.Insightly
{
    public class Tag
    {
        [JsonProperty("TAG_NAME", NullValueHandling = NullValueHandling.Ignore)]
        public string TAG_NAME { get; set; }
    }
}
