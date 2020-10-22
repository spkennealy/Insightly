using Newtonsoft.Json;

namespace Models.Submittable
{
    public class SubmittableWrapper
    {
        [JsonProperty("current_page", NullValueHandling = NullValueHandling.Ignore)]
        public int? CURRENT_PAGE { get; set; }

        [JsonProperty("total_pages", NullValueHandling = NullValueHandling.Ignore)]
        public int? TOTAL_PAGES { get; set; }

        [JsonProperty("total_items", NullValueHandling = NullValueHandling.Ignore)]
        public int? TOTAL_ITEMS { get; set; }

        [JsonProperty("items_per_page", NullValueHandling = NullValueHandling.Ignore)]
        public int? ITEMS_PER_PAGE { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public object ITEMS { get; set; }
    }
}
