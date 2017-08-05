using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using StarWars.Models;
using StarWars.Stores;
using System;

namespace StarWars.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class AfiliationsController : Controller
    {
        [HttpGet, Route("")]
        public JsonResult GetAll()
        {
            return Json(
                Enum.GetNames(typeof(Afiliations))
            );
        }

        [HttpGet, Route("{afiliation}/people")]
        public JsonResult GetPeopleFromAffiliation(Afiliations afiliation)
        {
            return Json(
                PeopleStore.Store.Where( people => people.afiliation.ToString() == afiliation.ToString() )
            );
        }

        [HttpGet, Route("{afiliation}/planets")]
        public JsonResult GetPlanetsFromAffiliation(Afiliations afiliation)
        {
            return Json(
                PlanetStore.Store.Where( planet => planet.afiliation.ToString() == afiliation.ToString() )
            );
        }
    }
}