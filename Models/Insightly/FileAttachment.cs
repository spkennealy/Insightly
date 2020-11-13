using System;
using System.IO;
using Newtonsoft.Json;

namespace Models.Insightly
{
    public class FileAttachment
    {
        [JsonProperty("FILE_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? FILE_ID { get; set; }

        [JsonProperty("FILE_NAME", NullValueHandling = NullValueHandling.Ignore)]
        public string FILE_NAME { get; set; }

        [JsonProperty("CONTENT_TYPE", NullValueHandling = NullValueHandling.Ignore)]
        public string CONTENT_TYPE { get; set; }

        [JsonProperty("FILE_SIZE", NullValueHandling = NullValueHandling.Ignore)]
        public long? FILE_SIZE { get; set; }

        [JsonProperty("FILE_CATEGORY_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? FILE_CATEGORY_ID { get; set; }

        [JsonProperty("OWNER_USER_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? OWNER_USER_ID { get; set; }

        [JsonProperty("DATE_CREATED_UTC", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DATE_CREATED_UTC { get; set; }

        [JsonProperty("DATE_UPDATED_UTC", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DATE_UPDATED_UTC { get; set; }

        [JsonProperty("URL", NullValueHandling = NullValueHandling.Ignore)]
        public string URL { get; set; }

        [JsonProperty("FILE", NullValueHandling = NullValueHandling.Ignore)]
        public FileStream FILE { get; set; }
    }
}
