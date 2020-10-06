using System.Collections.Generic;
using Newtonsoft.Json;

namespace Models.Insightly.CustomFieldDetails
{
    public class Dependency
    {
        [JsonProperty("CONTROLLING_FIELD_ID", NullValueHandling = NullValueHandling.Ignore)]
        public string CONTROLLING_FIELD_ID { get; set; }

        [JsonProperty("OPTIONS_FILTERS", NullValueHandling = NullValueHandling.Ignore)]
        public List<OptionsFilter> OPTIONS_FILTERS { get; set; }
    }
}
