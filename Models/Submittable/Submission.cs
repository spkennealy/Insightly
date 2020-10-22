using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Models.Submittable
{
    public class Submission
    {
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public Category CATEGORY { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string URL { get; set; }

        [JsonProperty("link", NullValueHandling = NullValueHandling.Ignore)]
        public string LINK { get; set; }

        [JsonProperty("submission_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? SUBMISSION_ID { get; set; }

        [JsonProperty("date_created", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DATE_CREATED { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string TITLE { get; set; }

        [JsonProperty("submission_content", NullValueHandling = NullValueHandling.Ignore)]
        public string SUBMISSION_CONTENT { get; set; }

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string STATUS { get; set; }

        [JsonProperty("is_archived", NullValueHandling = NullValueHandling.Ignore)]
        public bool IS_ARCHIVED { get; set; }

        [JsonProperty("submitter", NullValueHandling = NullValueHandling.Ignore)]
        public Submitter SUBMITTER { get; set; }

        [JsonProperty("form", NullValueHandling = NullValueHandling.Ignore)]
        public Form FORM { get; set; }

        [JsonProperty("payment", NullValueHandling = NullValueHandling.Ignore)]
        public string PAYMENT { get; set; } // NOT SURE ON THE TYPE

        [JsonProperty("files", NullValueHandling = NullValueHandling.Ignore)]
        public List<SubmittableFile> FILES { get; set; }

        [JsonProperty("assignments", NullValueHandling = NullValueHandling.Ignore)]
        public Assignments ASSIGNMENTS { get; set; }

        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public Labels LABELS { get; set; }

        [JsonProperty("votes", NullValueHandling = NullValueHandling.Ignore)]
        public Votes VOTES { get; set; }

        [JsonProperty("reviews", NullValueHandling = NullValueHandling.Ignore)]
        public Reviews REVIEWS { get; set; }

        [JsonProperty("forms", NullValueHandling = NullValueHandling.Ignore)]
        public object FORMS { get; set; }

        [JsonProperty("history", NullValueHandling = NullValueHandling.Ignore)]
        public object HISTORY { get; set; }
    }
}
