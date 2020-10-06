using System.Collections.Generic;
using Newtonsoft.Json;

namespace Models.Insightly.CustomFieldDetails
{
    public class CustomFieldDetail
    {
        [JsonProperty("FIELD_NAME", NullValueHandling = NullValueHandling.Ignore)]
        public string FIELD_NAME { get; set; }

        [JsonProperty("FIELD_ORDER", NullValueHandling = NullValueHandling.Ignore)]
        public long? FIELD_ORDER { get; set; }

        [JsonProperty("FIELD_FOR", NullValueHandling = NullValueHandling.Ignore)]
        public string FIELD_FOR { get; set; }

        [JsonProperty("FIELD_LABEL", NullValueHandling = NullValueHandling.Ignore)]
        public string FIELD_LABEL { get; set; }

        [JsonProperty("FIELD_TYPE", NullValueHandling = NullValueHandling.Ignore)]
        public string FIELD_TYPE { get; set; }

        [JsonProperty("FIELD_HELP_TEXT", NullValueHandling = NullValueHandling.Ignore)]
        public string FIELD_HELP_TEXT { get; set; }

        [JsonProperty("DEFAULT_VALUE", NullValueHandling = NullValueHandling.Ignore)]
        public string DEFAULT_VALUE { get; set; }

        [JsonProperty("EDITABLE", NullValueHandling = NullValueHandling.Ignore)]
        public bool EDITABLE { get; set; }

        [JsonProperty("VISIBLE", NullValueHandling = NullValueHandling.Ignore)]
        public bool VISIBLE { get; set; }

        [JsonProperty("CUSTOM_FIELD_OPTIONS", NullValueHandling = NullValueHandling.Ignore)]
        public List<CustomFieldOption> CUSTOM_FIELD_OPTIONS { get; set; }

        [JsonProperty("DEPENDENCY", NullValueHandling = NullValueHandling.Ignore)]
        public Dependency DEPENDENCY { get; set; }

        [JsonProperty("JOIN_OBJECT", NullValueHandling = NullValueHandling.Ignore)]
        public string JOIN_OBJECT { get; set; }
    }
}
