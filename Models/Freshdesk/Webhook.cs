using System;
using Newtonsoft.Json;

namespace Models.Freshdesk
{
    public class Webhook
    {
        [JsonProperty("freshdesk_webhook")]
        public TicketNotification FRESHDESK_TICKET_NOTIFICATION { get; set; }
    }
}
