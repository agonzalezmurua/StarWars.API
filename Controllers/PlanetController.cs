using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using StarWars.Models;
using StarWars.Stores;

namespace StarWars.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class PlanetsController : Controller
    {
        [HttpGet, Route("")]
        public JsonResult GetAll() 
        {
            return Json(PlanetStore.Store);
        }

        [HttpGet, Route("{id:int}")]
        public JsonResult Get(int id) 
        {
            return Json(
                PlanetStore.Store.FirstOrDefault( planet => planet.id == id)
            );
        }

        [HttpGet, Route("{planetId:int}/people")]
        public JsonResult GetPeopleByPlanet(int planetId)
        {
            return Json(
                PeopleStore.Store.Where( people => people.planeta_natal != null && people.planeta_natal.id == planetId )
            );
        }
    }
}