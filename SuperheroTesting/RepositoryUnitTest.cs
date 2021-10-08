using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NUnit.Framework;
using SuperheroClient.Models;
using SuperheroClient.Repository;
using Newtonsoft.Json;

namespace SuperheroTesting
{
  [TestFixture]
  public class Tests
  {
    private IHeroRepository _repository;

    [SetUp]
    public void Setup()
    {
      _repository = new HeroRepository();
    }

    [TestCase("ThisIsNotASuperHeroName")]
    public async Task getHeroFail(string filter){
      var response = await _repository.searchHero(filter);
      Assert.IsNotNull(response.error);
    }

    [TestCase("iron")]
    public async Task getHeroById(string filter){
      var response = await _repository.searchHero(filter);
      Assert.IsInstanceOf<List<HeroModel>>(response.results);
    }

    [TestCase(-1)]
    [TestCase(0)]
    public async Task getHeroFail(int id){
      var response = await _repository.getHero(id);
      Assert.IsNotNull(response.error);
    }

    [TestCase(1)]
    [TestCase(2)]
    public async Task getHeroById(int id){
      var response = await _repository.getHero(id);
      Assert.IsInstanceOf<HeroModel>(response.hero);
    }

    [Test]
    public async Task getHero1()
    {
      var actual = await _repository.getHero(1);

      var expected = new HeroResponseModel
      {
        response = "success",
        hero = new HeroModel {
          id = 1,
          name = "A-Bomb",
          powerstats = new PowerstatsModel
          {
            intelligence = 38,
            strength = 100,
            speed = 17,
            durability = 80,
            power = 24,
            combat = 64
          },
          biography = new BiographyModel
          {
            fullName = "Richard Milhouse Jones",
            alterEgos = "No alter egos found.",
            aliases = new List<string>(){
              "Rick Jones"
          },
            placeOfBirth = "Scarsdale, Arizona",
            firstAppearance = "Hulk Vol 2 #2 (April, 2008) (as A-Bomb)",
            publisher = "Marvel Comics",
            alignment = "good"
          },
          appearance = new AppearanceModel
          {
            gender = "Male",
            race = "Human",
            height = new List<string>{
              "6'8",
              "203 cm"
            },
            weight = new List<string>{
              "980 lb",
              "441 kg"
            },
            eyeColor = "Yellow",
            hairColor = "No Hair"
          },
          work = new WorkModel
          {
            occupation = "Musician, adventurer, author; formerly talk show host",
            location = "-"
          },
          connections = new ConnectionsModel
          {
            groupAffiliation = "Hulk Family; Excelsior (sponsor), Avengers (honorary member); formerly partner of the Hulk, Captain America and Captain Marvel; Teen Brigade; ally of Rom",
            relatives = "Marlo Chandler-Jones (wife); Polly (aunt); Mrs. Chandler (mother-in-law); Keith Chandler, Ray Chandler, three unidentified others (brothers-in-law); unidentified father (deceased); Jackie Shorr (alleged mother; unconfirmed)"
          },
          image = new ImageModel
          {
            url = "https://www.superherodb.com/pictures2/portraits/10/100/10060.jpg"
          }
        }
      };

      var actualSerialized = JsonConvert.SerializeObject(actual);
      var expectedSerialized = JsonConvert.SerializeObject(expected);
      
      Assert.True(actualSerialized.Equals(expectedSerialized));
    }
  }
}