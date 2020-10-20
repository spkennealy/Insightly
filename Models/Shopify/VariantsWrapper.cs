using System.Collections.Generic;
using Newtonsoft.Json;

namespace Models.Shopify
{
    public class VariantsWrapper
    {
        [JsonProperty("variants")]
        public List<Variant> VARIANTS { get; set; }
    }
}
