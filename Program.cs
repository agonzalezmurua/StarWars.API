using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using StarWars.Models;

namespace StarWars.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LoadFakeDatabase();

            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();   

            host.Run();
        }

        private static void LoadFakeDatabase()
        {
            Stores.PlanetStore.Store =  new List<Planet>()
            {
                new Models.Planet() {
                    id = 1,
                    afiliation = Afiliations.NEUTRAL,
                    climate = Climates.DRY,
                    population = 5000,
                    name = "Stewjon",
                    hasWater = true
                },
            };

            Stores.PeopleStore.Store = new List<StarWars.Models.People>()
            {
                new Models.People() {
                    id = 1,
                    afiliation = Afiliations.JEDI,
                    agility = 7,
                    wisdom = 10,
                    gender = Genders.MALE,
                    strength = 5,
                    resilience = 5,
                    name = "Obi Wan Kennobi",
                    homeworld = Stores.PlanetStore.Get(1)
                },
            };
        }
    }
}
