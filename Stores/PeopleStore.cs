using System;
using System.Collections.Generic;

namespace API.Stores
{
    public static class PeopleStore
    {
        private static List<API.Models.People> _store = new List<API.Models.People>();
        public static List<API.Models.People> Store
        {
            get { return _store;}
        }
    }
}