using System.Collections.Generic;
using Newtonsoft.Json;

namespace Models.Insightly.CustomFieldDetails
{
    public class OptionsFilter
    {
        [JsonProperty("CONTROLLING_VALUE", NullValueHandling = NullValueHandling.Ignore)]
        public string CONTROLLING_VALUE { get; set; }

        [JsonProperty("OPTION_IDS", NullValueHandling = NullValueHandling.Ignore)]
        public List<long?> OPTION_IDS { get; set; }
    }
}
