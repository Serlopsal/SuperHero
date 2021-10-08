using Newtonsoft.Json;

namespace SuperheroClient.Models
{
  public class ImageModel
  {
    [JsonProperty("url")]
    public string url { get; set; }
  }
}