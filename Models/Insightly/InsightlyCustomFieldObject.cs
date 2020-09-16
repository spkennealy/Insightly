using Newtonsoft.Json;
using System.Collections.Generic;

namespace Models.Insightly
{
    public class InsightlyCustomFieldObject
    {
        [JsonProperty("CUSTOMFIELDS", NullValueHandling = NullValueHandling.Ignore)]
        public List<CustomField> CUSTOMFIELDS { get; set; }
    }
}
