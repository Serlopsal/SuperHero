using Newtonsoft.Json;

namespace SuperheroClient.Models{
  public class PowerstatsModel
  {
    [JsonProperty("intelligence")]
    public int? intelligence { get; set; }
    
    [JsonProperty("strength")]
    public int? strength { get; set; }
    
    [JsonProperty("speed")]
    public int? speed { get; set; }
    
    [JsonProperty("durability")]
    public int? durability { get; set; }
    
    [JsonProperty("power")]
    public int? power { get; set; }
    
    [JsonProperty("combat")]
    public int? combat { get; set; }
  }
}