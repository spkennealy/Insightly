using System.Collections.Generic;
using Newtonsoft.Json;

namespace Models.Shopify
{
    public class CustomersWrapper
    {
        [JsonProperty("customers")]
        public List<Customer> CUSTOMERS { get; set; }

        [JsonProperty("customer")]
        public Customer CUSTOMER { get; set; }
    }
}
