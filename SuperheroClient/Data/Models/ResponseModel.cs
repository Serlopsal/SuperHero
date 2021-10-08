using Newtonsoft.Json;

namespace SuperheroClient.Models{
  public class ResponseModel{

    [JsonProperty("response")]
    public string response { get; set; }


    [JsonProperty("error")]
    public string error { get; set; }
  }
}