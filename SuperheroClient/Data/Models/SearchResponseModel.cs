using System.Collections.Generic;
using Newtonsoft.Json;

namespace SuperheroClient.Models{
  public class SearchResponseModel : ResponseModel
  {
    [JsonProperty("results-for")]
    public string resultsFor { get; set; }
    
    [JsonProperty("results")]
    public List<HeroModel> results { get; set; }
  }
}