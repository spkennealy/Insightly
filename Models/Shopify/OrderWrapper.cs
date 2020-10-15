using System.Collections.Generic;
using Newtonsoft.Json;

namespace Models.Shopify
{
    public class OrderWrapper
    {
        [JsonProperty("orders")]
        public List<Order> ORDERS { get; set; }

        [JsonProperty("order")]
        public Order ORDER { get; set; }
    }
}
