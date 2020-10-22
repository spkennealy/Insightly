using Newtonsoft.Json;

namespace Models.Submittable
{
    public class SubmittableFile
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? ID { get; set; }

        [JsonProperty("guid", NullValueHandling = NullValueHandling.Ignore)]
        public string GUID { get; set; }

        [JsonProperty("form_field_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? FORM_FIELD_ID { get; set; }

        [JsonProperty("file_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FILE_NAME { get; set; }

        [JsonProperty("file_extension", NullValueHandling = NullValueHandling.Ignore)]
        public string FILE_EXTENSION { get; set; }

        [JsonProperty("file_size", NullValueHandling = NullValueHandling.Ignore)]
        public long? FILE_SIZE { get; set; }

        [JsonProperty("mime_type", NullValueHandling = NullValueHandling.Ignore)]
        public string MIME_TYPE { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string URL { get; set; }

        [JsonProperty("transcoded_url", NullValueHandling = NullValueHandling.Ignore)]
        public string TRANSCODED_URL { get; set; }
    }
}
