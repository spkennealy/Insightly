using Newtonsoft.Json;

namespace Models.Insightly
{
    public class InsightlyWebhook
    {
        [JsonProperty("entity")]
        public object ENTITY { get; set; }
    }
}
