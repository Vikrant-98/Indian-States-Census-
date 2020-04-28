using Newtonsoft.Json;

namespace IndianStatesCensus
{
    public class Entries
    {
        
        public string State { get; set; }
        [JsonProperty(" Population", NullValueHandling = NullValueHandling.Ignore)]
        public string Population { get; set; }

        [JsonProperty("AreaInSqKm", NullValueHandling = NullValueHandling.Ignore)]
        public string AreaInSqKm { get; set; }

        [JsonProperty("DensityPerSqKm", NullValueHandling = NullValueHandling.Ignore)]
        public string DensityPerSqKm { get; set; }

        [JsonProperty("SrNo", NullValueHandling = NullValueHandling.Ignore)]
        public string SrNo { get; set; }

        [JsonProperty("TIN", NullValueHandling = NullValueHandling.Ignore)]
        public string TIN { get; set; }

        [JsonProperty("StateCode", NullValueHandling = NullValueHandling.Ignore)]
        public string StateCode { get; set; }
        
    }
}
