using System;
using Newtonsoft.Json;

namespace Models.Freshdesk
{
    public class Attachment
    {
        [JsonProperty("id")]
        public long? ID { get; set; }

        [JsonProperty("content_type")]
        public string CONTENT_TYPE { get; set; }

        [JsonProperty("file_size")]
        public long? FILE_SIZE { get; set; }

        [JsonProperty("name")]
        public string NAME { get; set; }

        [JsonProperty("attachment_url")]
        public string ATTACHMENT_URL { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CREATED_AT { get; set; }

        [JsonProperty("updated_at")]
        public DateTime? UPDATED_AT { get; set; }
    }
}
