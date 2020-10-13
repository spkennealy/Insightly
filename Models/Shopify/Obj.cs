using Newtonsoft.Json;

namespace Models.Shopify
{
    public class Obj
    {
        [JsonProperty("name")]
        public string NAME { get; set; }

        [JsonProperty("value")]
        public string VALUE { get; set; }
    }
}
