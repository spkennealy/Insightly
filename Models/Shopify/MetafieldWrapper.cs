using System.Collections.Generic;
using Newtonsoft.Json;

namespace Models.Shopify
{
    public class MetafieldWrapper
    {
        [JsonProperty("metafield")]
        public Metafield METAFIELD { get; set; }

        [JsonProperty("metafields")]
        public List<Metafield> METAFIELDS { get; set; }
    }
}
