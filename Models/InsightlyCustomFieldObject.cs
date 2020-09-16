using Newtonsoft.Json;
using System.Collections.Generic;

namespace Models
{
    public class InsightlyCustomFieldObject
    {
        [JsonProperty("CUSTOMFIELDS", NullValueHandling = NullValueHandling.Ignore)]
        public List<CustomField> CUSTOMFIELDS { get; set; }
    }
}
