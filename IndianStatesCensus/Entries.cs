using Newtonsoft.Json;

namespace IndianStatesCensus
{
    public class Entries
    {

        [JsonProperty("State", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        [JsonProperty("Population", NullValueHandling = NullValueHandling.Ignore)]
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

        [JsonProperty("State_Id", NullValueHandling = NullValueHandling.Ignore)]
        public string State_Id { get; set; }

        [JsonProperty("Housing_units", NullValueHandling = NullValueHandling.Ignore)]
        public string Housing_units { get; set; }

        [JsonProperty("Total_area", NullValueHandling = NullValueHandling.Ignore)]
        public string Total_area { get; set; }

        [JsonProperty("Water_area", NullValueHandling = NullValueHandling.Ignore)]
        public string Water_area { get; set; }

        [JsonProperty("Land_area", NullValueHandling = NullValueHandling.Ignore)]
        public string Land_area { get; set; }

        [JsonProperty("Population_Density", NullValueHandling = NullValueHandling.Ignore)]
        public string Population_Density { get; set; }

        [JsonProperty("Housing_Density", NullValueHandling = NullValueHandling.Ignore)]
        public string Housing_Density { get; set; }

    }
}
