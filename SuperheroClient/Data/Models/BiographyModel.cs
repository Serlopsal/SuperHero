using System.Collections.Generic;
using Newtonsoft.Json;

namespace SuperheroClient.Models{

  public class BiographyModel
  {
    [JsonProperty("full-name")]
    public string fullName { get; set; }
    
    [JsonProperty("alter-egos")]
    public string alterEgos { get; set; }
    
    [JsonProperty("aliases")]
    public List<string> aliases { get; set; }
    
    [JsonProperty("place-of-birth")]
    public string placeOfBirth { get; set; }
    
    [JsonProperty("first-appearance")]
    public string firstAppearance { get; set; }
    
    [JsonProperty("publisher")]
    public string publisher { get; set; }
    
    [JsonProperty("alignment")]
    public string alignment { get; set; }
  }
}