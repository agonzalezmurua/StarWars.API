using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using StarWars.Models;
using StarWars.Stores;
using System;

namespace StarWars.Controllers
{
    [Route("api/[controller]")]
    public class AfiliationsController : Controller
    {
        [HttpGet, Route("")]
        public IEnumerable<string> GetAll()
        {
            return Enum.GetNames(typeof(Afiliations));
        }

        [HttpGet, Route("{afiliation}/people")]
        public IEnumerable<People> GetPeopleFromAffiliation(Afiliations afiliation)
        {
            return PeopleStore.Store.Where( people => people.afiliation.ToString() == afiliation.ToString() );
        }

        [HttpGet, Route("{afiliation}/planets")]
        public IEnumerable<Planet> GetPlanetsFromAffiliation(Afiliations afiliation)
        {
            return PlanetStore.Store.Where( planet => planet.afiliation.ToString() == afiliation.ToString() );
        }
    }
}