using Newtonsoft.Json;

namespace Models.Shopify
{
    public class Address
    {
        [JsonProperty("id")]
        public long? ID { get; set; }

        [JsonProperty("address1")]
        public string ADDRESS_1 { get; set; }

        [JsonProperty("address2")]
        public string ADDRESS_2 { get; set; }

        [JsonProperty("city")]
        public string CITY { get; set; }

        [JsonProperty("company")]
        public string COMPANY { get; set; }

        [JsonProperty("country")]
        public string COUNTRY { get; set; }

        [JsonProperty("first_name")]
        public string FIRST_NAME { get; set; }

        [JsonProperty("last_name")]
        public string LAST_NAME { get; set; }

        [JsonProperty("latitude")]
        public string LATITUDE { get; set; }

        [JsonProperty("longitude")]
        public string LONGITUDE { get; set; }

        [JsonProperty("phone")]
        public string PHONE { get; set; }

        [JsonProperty("province")]
        public string PROVINCE { get; set; }

        [JsonProperty("zip")]
        public string ZIP { get; set; }

        [JsonProperty("name")]
        public string NAME { get; set; }

        [JsonProperty("country_code")]
        public string COUNTRY_CODE { get; set; }

        [JsonProperty("province_code")]
        public string PROVINCE_CODE { get; set; }

        [JsonProperty("default")]
        public bool DEFUALT { get; set; }
    }
}
