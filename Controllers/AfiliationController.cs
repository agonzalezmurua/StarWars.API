using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using StarWars.Models;
using StarWars.Stores;
using System;

namespace StarWars.Controllers
{
    [Route("api/[controller]")]
    public class AfiliationController : Controller
    {
        [HttpGet, Route("")]
        public Dictionary<string, int> GetAll()
        {
            var afilDictionary = new Dictionary<string, int>();
            foreach(Afiliations afiliation in Enum.GetValues(typeof(Afiliations)))
            {
                afilDictionary.Add( afiliation.ToString(), (int)afiliation);
            }
            return afilDictionary;
        }

        [HttpGet, Route("{intVal:int}")]
        public KeyValuePair<string, int> GetFromInt(int intVal)
        {
            Afiliations afiliation = (Afiliations)intVal;
            return new KeyValuePair<string, int>( afiliation.ToString(), (int)afiliation );
        }

        [HttpGet, Route("{afiliation}/people")]
        public IEnumerable<People> GetPeopleFromAffiliation(Afiliations afiliation)
        {
            return PeopleStore.Store.Where( people => people.afiliation == afiliation.ToString() );
        }

        [HttpGet, Route("{afiliation}/planets")]
        public IEnumerable<Planet> GetPlanetsFromAffiliation(Afiliations afiliation)
        {
            return PlanetStore.Store.Where( planet => planet.afiliation == afiliation.ToString() );
        }

        [HttpGet, Route("{stringVal:alpha}")]
        public KeyValuePair<string,int> GetFromName(string stringVal)
        {
            Afiliations afiliation = (Afiliations)Enum.Parse(typeof(Afiliations), stringVal);
            return new KeyValuePair<string, int>( afiliation.ToString(), (int)afiliation );
        }
    }
}