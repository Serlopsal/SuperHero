using System.Threading.Tasks;

using SuperheroClient.Models;

namespace SuperheroClient.Repository {
  public interface IHeroRepository {
    Task<HeroResponseModel> getHero(int id);
  }
}