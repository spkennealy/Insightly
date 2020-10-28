using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Models.Freshdesk
{
    public class TicketField
    {
        [JsonProperty("id")]
        public long? ID { get; set; }

        [JsonProperty("name")]
        public string NAME { get; set; }

        [JsonProperty("label")]
        public string LABEL { get; set; }

        [JsonProperty("label_for_customers")]
        public string LABEL_FOR_CUSTOMERS { get; set; }

        [JsonProperty("position")]
        public int? POSITION { get; set; }

        [JsonProperty("type")]
        public string TYPE { get; set; }

        [JsonProperty("default")]
        public bool DEFAULT { get; set; }

        [JsonProperty("customers_can_edit")]
        public bool CUSTOMERS_CAN_EDIT { get; set; }

        [JsonProperty("required_for_closure")]
        public bool REQUIRED_FOR_CLOSURE { get; set; }

        [JsonProperty("required_for_agents")]
        public bool REQUIRED_FOR_AGENTS { get; set; }

        [JsonProperty("required_for_customers")]
        public bool REQUIRED_FOR_CUSTOMERS { get; set; }

        [JsonProperty("displayed_to_customers")]
        public bool DISPLAYED_TO_CUSTOMERS { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CREATED_AT { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UPDATED_AT { get; set; }

        [JsonProperty("archived")]
        public bool ARCHIVED { get; set; }

        [JsonProperty("choices")]
        public List<Choice> CHOICES { get; set; }
    }
}
