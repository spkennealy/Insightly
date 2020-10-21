using Newtonsoft.Json;

namespace Models.Submittable
{
    public class FormField
    {
        [JsonProperty("form_field_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? FORM_FIELD_ID { get; set; }

        [JsonProperty("field_type", NullValueHandling = NullValueHandling.Ignore)]
        public string FIELD_TYPE { get; set; }

        [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
        public string LABEL { get; set; }

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public string DATA { get; set; }

        [JsonProperty("blind", NullValueHandling = NullValueHandling.Ignore)]
        public bool BLIND { get; set; }

        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
        public int? ORDER { get; set; }
    }
}
