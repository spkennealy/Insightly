using System.Collections.Generic;
using Newtonsoft.Json;

namespace Models.Submittable
{
    public class Labels
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string TYPE { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string URL { get; set; }

        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? COUNT { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<Label> ITEMS { get; set; }
    }
}
