using System.Collections.Generic;
using System.Linq;

namespace StarWars.Stores
{
    public static class PlanetStore {
        private static List<StarWars.Models.Planet> _planets;
        public static List<StarWars.Models.Planet> Store
        {
            get { return _planets;}
            set { _planets = value;}
        }
        public static StarWars.Models.Planet Get(int id)
        {
            return _planets.FirstOrDefault( planet => planet.id == id );
        }
    }
}