using Newtonsoft.Json;

namespace Models.Freshdesk
{
    public class Choice
    {
        [JsonProperty("id")]
        public int? ID { get; set; }

        [JsonProperty("label_for_customers")]
        public string LABEL_FOR_CUSTOMERS { get; set; }

        [JsonProperty("value")]
        public string VALUE { get; set; }

        [JsonProperty("stop_sla_timer")]
        public bool STOP_SLA_TIMER { get; set; }

        [JsonProperty("default")]
        public bool DEFAULT { get; set; }

        [JsonProperty("position")]
        public int? POSITION { get; set; }

        [JsonProperty("deleted")]
        public bool DELETED { get; set; }
    }
}
