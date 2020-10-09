using System.Collections.Generic;
using Newtonsoft.Json;

namespace Models.Shopify
{
    public class DraftOrderWrapper
    {
        [JsonProperty("draft_order")]
        public DraftOrder DRAFT_ORDER { get; set; }

        [JsonProperty("draft_orders")]
        public List<DraftOrder> DRAFT_ORDERS { get; set; }

        [JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]
        public string ERROR { get; set; }
    }
}
