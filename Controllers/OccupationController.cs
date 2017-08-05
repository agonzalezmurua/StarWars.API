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
    public class OccupationController : Controller
    {
        [HttpGet, Route("")]
        public JsonResult GetAll()
        {
            return Json(
                Enum.GetNames(typeof(Occupations))
            );
        }

        [HttpGet, Route("{occupation}/people")]
        public JsonResult GetPeopleFromAffiliation(Occupations occupation)
        {
            return Json(
                PeopleStore.Store.Where(people => people.occupation.ToString() == occupation.ToString())
            );
        }
    }
}