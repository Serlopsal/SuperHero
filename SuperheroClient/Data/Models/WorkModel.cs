using Newtonsoft.Json;

namespace SuperheroClient.Models
{
  public class WorkModel
  {
    [JsonProperty("occupation")]
    public string occupation { get; set; }

    [JsonProperty("base")]
    public string location { get; set; }
  }
}