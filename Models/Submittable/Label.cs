using Newtonsoft.Json;

namespace Models.Submittable
{
    public class Label
    {
        [JsonProperty("label_text", NullValueHandling = NullValueHandling.Ignore)]
        public string LABEL_TEXT { get; set; }

        [JsonProperty("label_color1", NullValueHandling = NullValueHandling.Ignore)]
        public string LABEL_COLOR_1 { get; set; }

        [JsonProperty("label_color2", NullValueHandling = NullValueHandling.Ignore)]
        public string LABEL_COLOR_2 { get; set; }
    }
}
