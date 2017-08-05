using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using StarWars.Models;
using StarWars.Stores;

namespace StarWars.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class PeopleController : Controller
    {
        [HttpGet, Route("")]
        public JsonResult GetAll()
        {
            return Json(PeopleStore.Store);
        }

        [HttpGet, Route("{id:int}")]
        public JsonResult Get(int id)
        {
            return Json(
                PeopleStore.Store.FirstOrDefault( people => people.id == id )
            );
        }

        [HttpGet, Route("occupation/{occupation}")]
        public JsonResult GetByOccupation(Occupations occupation)
        {
            return Json(
                PeopleStore.Store.Where(people => people.occupation == occupation.ToString())
            );
        }
    }
}