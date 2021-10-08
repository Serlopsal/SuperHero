using Newtonsoft.Json;

namespace SuperheroClient.Models
{
  public class ConnectionsModel
  {
    [JsonProperty("group-affiliation")]
    public string groupAffiliation { get; set; }

    [JsonProperty("relatives")]
    public string relatives { get; set; }
  }
}