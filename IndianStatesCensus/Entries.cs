using Newtonsoft.Json;

namespace IndianStatesCensus
{
    /// <summary>
    /// Get input and set it in perticular Tupples
    /// </summary>
    public class Entries
    {
        //states Field Entry
        [JsonProperty("State", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }
        
        //Population Field Entry
        [JsonProperty("Population", NullValueHandling = NullValueHandling.Ignore)]
        public string Population { get; set; }
        
        //Area in Square kilometer Field Entry
        [JsonProperty("AreaInSqKm", NullValueHandling = NullValueHandling.Ignore)]
        public string AreaInSqKm { get; set; }
        
        //Density pre Square Kilometer Feild Entry
        [JsonProperty("DensityPerSqKm", NullValueHandling = NullValueHandling.Ignore)]
        public string DensityPerSqKm { get; set; }
        
        //Serial number Field Entry
        [JsonProperty("SrNo", NullValueHandling = NullValueHandling.Ignore)]
        public string SrNo { get; set; }
        
        //TIN Field Entry
        [JsonProperty("TIN", NullValueHandling = NullValueHandling.Ignore)]
        public string TIN { get; set; }
        
        //State Code Field Entry
        [JsonProperty("StateCode", NullValueHandling = NullValueHandling.Ignore)]
        public string StateCode { get; set; }
        
        //State ID Field Entry
        [JsonProperty("State_Id", NullValueHandling = NullValueHandling.Ignore)]
        public string State_Id { get; set; }
        
        //Housing Unit Field Entry
        [JsonProperty("Housing_units", NullValueHandling = NullValueHandling.Ignore)]
        public string Housing_units { get; set; }
        
        //Total Area Field Entry
        [JsonProperty("Total_area", NullValueHandling = NullValueHandling.Ignore)]
        public string Total_area { get; set; }
        
        //Water Area Field Entry
        [JsonProperty("Water_area", NullValueHandling = NullValueHandling.Ignore)]
        public string Water_area { get; set; }
        
        //Land Area Field Entry
        [JsonProperty("Land_area", NullValueHandling = NullValueHandling.Ignore)]
        public string Land_area { get; set; }
        
        //Population Density Field Entry
        [JsonProperty("Population_Density", NullValueHandling = NullValueHandling.Ignore)]
        public string Population_Density { get; set; }
        
        //Housing Density Field Entry
        [JsonProperty("Housing_Density", NullValueHandling = NullValueHandling.Ignore)]
        public string Housing_Density { get; set; }

    }
}
