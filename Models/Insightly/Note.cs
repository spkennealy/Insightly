using System;
using Newtonsoft.Json;

namespace Models.Insightly
{
    public class Note
    {
        [JsonProperty("NOTE_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? NOTE_ID { get; set; }

        [JsonProperty("TITLE", NullValueHandling = NullValueHandling.Ignore)]
        public string TITLE { get; set; }

        [JsonProperty("BODY", NullValueHandling = NullValueHandling.Ignore)]
        public string BODY { get; set; }

        [JsonProperty("DATE_CREATED_UTC", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DATE_CREATED_UTC { get; set; }

        [JsonProperty("DATE_UPDATED_UTC", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DATE_UPDATED_UTC { get; set; }
    }
}
