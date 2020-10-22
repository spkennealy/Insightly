using System.Collections.Generic;
using Newtonsoft.Json;

namespace Models.Submittable
{
    public class Reviews
    {
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? COUNT { get; set; }

        [JsonProperty("score", NullValueHandling = NullValueHandling.Ignore)]
        public int? SCORE { get; set; }

        [JsonProperty("average", NullValueHandling = NullValueHandling.Ignore)]
        public double? AVERAGE { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<Review> ITEMS { get; set; }
    }
}
