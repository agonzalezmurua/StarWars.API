using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using StarWars.Models;
using StarWars.Stores;

namespace StarWars.Controllers
{
    [Route("api/[controller]")]
    public class PlanetController : Controller
    {
        [HttpGet, Route("")]
        public IEnumerable<Planet> GetAll() 
        {
            return PlanetStore.Store;
        }

        [HttpGet, Route("{id:int}")]
        public Planet Get(int id) 
        {
            return PlanetStore.Store.FirstOrDefault( planet => planet.id == id);
        }

        [HttpGet, Route("{planetId:int}/people")]
        public IEnumerable<People> GetPeopleByPlanet(int planetId)
        {
            return PeopleStore.Store.Where( people => people.homeworld.id == planetId );
        }
    }
}