using System.Collections.Generic;
using Newtonsoft.Json;

namespace Models.Submittable
{
    public class Assignments
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string TYPE { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string URL { get; set; }

        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? COUNT { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<Assignment> ITEMS { get; set; }
    }
}
