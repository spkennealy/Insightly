using Newtonsoft.Json;

namespace Models.Insightly
{
    public class InsightlyWrapper
    {
        [JsonProperty("insightly")]
        public InsightlyRecordWrapper INSIGHTLY { get; set; }
    }
}
