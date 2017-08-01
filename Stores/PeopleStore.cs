using System;
using System.Collections.Generic;

namespace StarWars.Stores
{
    public static class PeopleStore
    {
        private static List<StarWars.Models.People> _store = new List<StarWars.Models.People>();
        public static List<StarWars.Models.People> Store
        {
            get { return _store;}
            set { _store = value; }
        }
    }
}