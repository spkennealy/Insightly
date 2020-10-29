using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Models.Freshdesk
{
    public class Ticket
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? ID { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string NAME { get; set; }

        [JsonProperty("requester_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? REQUESTER_ID { get; set; }

        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string EMAIL { get; set; }

        [JsonProperty("facebook_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FACEBOOK_ID { get; set; }

        [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
        public string PHONE { get; set; }

        [JsonProperty("twitter_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TWITTER_ID { get; set; }

        [JsonProperty("unique_external_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UNIQUE_EXTERNAL_ID { get; set; }

        [JsonProperty("subject", NullValueHandling = NullValueHandling.Ignore)]
        public string SUBJECT { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string TYPE { get; set; }

        // Open = 2, Pending = 3, Resolved = 4, Closed = 5
        // Default is 2
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? STATUS { get; set; }

        // Low = 1, Medium = 2, High = 3, Urgent = 4
        // Default is 1
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public int? PRIORITY { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string DESCRIPTION { get; set; }

        [JsonProperty("responder_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? RESPONDER_ID { get; set; }

        [JsonProperty("attachments", NullValueHandling = NullValueHandling.Ignore)]
        public List<Attachment> ATTACHMENTS { get; set; }

        [JsonProperty("cc_emails", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CC_EMAILS { get; set; }

        [JsonProperty("to_emails", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TO_EMAILS { get; set; }

        [JsonProperty("fwd_emails", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> FWD_EMAILS { get; set; }

        [JsonProperty("reply_cc_emails", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> REPLY_CC_EMAILS { get; set; }

        [JsonProperty("ticket_cc_emails", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TICKET_CC_EMAILS { get; set; }

        [JsonProperty("custom_fields", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, object> CUSTOM_FIELDS { get; set; }

        [JsonProperty("due_by", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DUE_BY { get; set; }

        [JsonProperty("email_config_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? EMAIL_CONFIG_ID { get; set; }

        [JsonProperty("fr_due_by", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? FR_DUE_BY { get; set; }

        //[JsonProperty("fr_escalated", NullValueHandling = NullValueHandling.Ignore)]
        //public bool FR_ESCALATED { get; set; }

        [JsonProperty("group_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? GROUP_ID { get; set; }

        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? PRODUCT_ID { get; set; }

        // Email = 1, Portal = 2, Phone = 3, Chat = 7, Mobihelp = 8, Feedback Widget = 9, Outbound Email = 10
        // Default is 2
        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public int? SOURCE { get; set; }

        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TAGS { get; set; }

        [JsonProperty("company_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? COMPANY_ID { get; set; }

        //[JsonProperty("spam", NullValueHandling = NullValueHandling.Ignore)]
        //public bool SPAM { get; set; }

        //[JsonProperty("urgent", NullValueHandling = NullValueHandling.Ignore)]
        //public bool URGENT { get; set; }

        //[JsonProperty("is_escalated", NullValueHandling = NullValueHandling.Ignore)]
        //public bool IS_ESCALATED { get; set; }

        [JsonProperty("description_text", NullValueHandling = NullValueHandling.Ignore)]
        public string DESCRIPTION_TEXT { get; set; }

        [JsonProperty("association_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ASSOCIATION_TYPE { get; set; }

        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CREATED_AT { get; set; }

        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UPDATED_AT { get; set; }

        [JsonProperty("source_additional_info", NullValueHandling = NullValueHandling.Ignore)]
        public string SOURCE_ADDITIONAL_INFO { get; set; }

        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DELETED { get; set; }
    }
}
