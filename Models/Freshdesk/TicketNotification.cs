using Newtonsoft.Json;

namespace Models.Freshdesk
{
    public class TicketNotification
    {
        [JsonProperty("type")]
        public string TYPE { get; set; }

        [JsonProperty("ticket_id")]
        public long? TICKET_ID { get; set; }

        [JsonProperty("ticket_url")]
        public string TICKET_URL { get; set; }
    }
}
