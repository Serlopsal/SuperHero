using Newtonsoft.Json;

namespace SuperheroClient.Models{
  public class HeroModel{
    [JsonProperty("id")]
    public int id { get; set; }

    [JsonProperty("name")]
    public string name { get; set; }
    public PowerstatsModel powerstats { get; set; }
    
    [JsonProperty("biography")]
    public BiographyModel biography { get; set; }
    
    [JsonProperty("appearance")]
    public AppearanceModel appearance { get; set; }
    
    [JsonProperty("work")]
    public WorkModel work { get; set; }
    
    [JsonProperty("connections")]
    public ConnectionsModel connections { get; set; }
    
    [JsonProperty("image")]
    public ImageModel image { get; set; }
  }
}