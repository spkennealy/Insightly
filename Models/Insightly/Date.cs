using Newtonsoft.Json;
using System;

namespace Models.Insightly
{
    public class Date
    {
        [JsonProperty("DATE_ID", NullValueHandling = NullValueHandling.Ignore)]
        public long? DATE_ID { get; set; }

        [JsonProperty("OCCASION_NAME", NullValueHandling = NullValueHandling.Ignore)]
        public string OCCASION_NAME { get; set; }

        [JsonProperty("OCCASION_DATE", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? OCCASION_DATE { get; set; }

        [JsonProperty("REPEAT_YEARLY", NullValueHandling = NullValueHandling.Ignore)]
        public bool REPEAT_YEARLY { get; set; }

        [JsonProperty("CREATE_TASK_YEARLY", NullValueHandling = NullValueHandling.Ignore)]
        public bool CREATE_TASK_YEARLY { get; set; }
    }
}
