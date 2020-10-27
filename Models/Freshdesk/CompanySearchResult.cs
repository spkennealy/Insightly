using System.Collections.Generic;
using Newtonsoft.Json;

namespace Models.Freshdesk
{
    public class CompanySearchResult
    {
        [JsonProperty("companies", NullValueHandling = NullValueHandling.Ignore)]
        public List<Company> COMPANIES { get; set; }
    }
}
