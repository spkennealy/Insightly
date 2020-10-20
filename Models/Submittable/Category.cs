using System;
using Newtonsoft.Json;

namespace Models.Submittable
{
    public class Category
    {
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string URL { get; set; }

        [JsonProperty("category_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? CATEGORY_ID { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string NAME { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string DESCRIPTION_1 { get; set; }

        [JsonProperty("Description", NullValueHandling = NullValueHandling.Ignore)]
        public string DESCRIPTION_2 { get; set; }

        [JsonProperty("blind_level", NullValueHandling = NullValueHandling.Ignore)]
        public string BLIND_LEVEL { get; set; } // NOT SURE ON TYPE

        [JsonProperty("blind_value", NullValueHandling = NullValueHandling.Ignore)]
        public string BLIND_VALUE { get; set; } // NOT SURE ON TYPE
    }
}
