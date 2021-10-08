using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

using SuperheroClient.Models;

namespace SuperheroClient.Repository {
  public class HeroRepository : IHeroRepository
  {
    private static readonly string _baseUrl = "https://superheroapi.com/api/4659769700751742";
    public async Task<HeroResponseModel> getHero(int id)
    {
      var client = new HttpClient();
      var url = _baseUrl + $"/{id}";
      var getter = await client.GetAsync(url);
      var stringContent = await getter.Content.ReadAsStringAsync();
      var responseContent = JsonConvert.DeserializeObject<HeroResponseModel>(stringContent);
      if(responseContent.response != "error")  
        responseContent.hero = JsonConvert.DeserializeObject<HeroModel>(stringContent);
      return responseContent;
    }

    public async Task<SearchResponseModel> searchHero(string filter){
      var client = new HttpClient();
      var url = _baseUrl + $"/search/{filter}";
      var getter = await client.GetAsync(url);
      var stringContent = await getter.Content.ReadAsStringAsync();
      var responseContent = JsonConvert.DeserializeObject<SearchResponseModel>(stringContent);
      return responseContent;
    }
  }
}