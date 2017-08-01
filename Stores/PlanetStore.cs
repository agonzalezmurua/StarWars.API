using System.Collections.Generic;

namespace API.Stores
{
    public static class PlanetStore {
        private static List<API.Models.Planet> _planets;
        public static List<API.Models.Planet> Planets
        {
            get { return _planets;}
            set { _planets = value;}
        }
        
    }
}