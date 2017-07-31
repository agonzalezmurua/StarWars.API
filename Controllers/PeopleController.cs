using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using API.Models;
using API.Stores;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class PeopleControllers : Controller
    {
        [HttpGet, Route("")]
        public IEnumerable<People> GetAll() {
            return PeopleStore.Store;
        }

        [HttpGet, Route("{id:int}")]
        public People Get(int id) {
            return PeopleStore.Store.FirstOrDefault( people => people.id == id );
        }
    }
}