using System.Collections.Generic;
using Newtonsoft.Json;

namespace SuperheroClient.Models
{
  public class AppearanceModel
  {
    [JsonProperty("gender")]
    public string gender { get; set; }  
    
    [JsonProperty("race")]
    public string race { get; set; }

    [JsonProperty("height")]
    public List<string> height { get; set; }

    [JsonProperty("weight")]
    public List<string> weight { get; set; }

    [JsonProperty("eye-color")]
    public string eyeColor { get; set; }

    [JsonProperty("hair-color")]
    public string hairColor { get; set; }
  }
}