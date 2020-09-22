using Newtonsoft.Json;

namespace Models.Insightly
{
    public class EmailDomain
    {
        [JsonProperty("EMAIL_DOMAIN_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? EMAIL_DOMAIN_ID { get; set; }

        [JsonProperty("EMAIL_DOMAIN", NullValueHandling = NullValueHandling.Ignore)]
        public string EMAIL_DOMAIN { get; set; }
    }
}
