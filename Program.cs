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
                    afiliation = Afiliations.Neutral.ToString(),
                    climate = Climates.Dry.ToString(),
                    population = 5000,
                    name = "Stewjon",
                    hasWater = true
                },
                new Models.Planet() {
                    id = 2,
                    afiliation = Afiliations.Old_Republic.ToString(),
                    climate = Climates.Temperate.ToString(),
                }
            };

            Stores.PeopleStore.Store = new List<StarWars.Models.People>()
            {
                new Models.People() {
                    id = 1,
                    afiliation = Afiliations.Galactic_Republic.ToString(),
                    agility = 5,
                    wisdom = 7,
                    gender = Genders.MALE.ToString(),
                    strength = 3,
                    resilience = 6,
                    name = "Obi-Wan Kennobi",
                    homeworld = Stores.PlanetStore.Get(1)
                },
                new Models.People() {
                    id = 2,
                    afiliation = Afiliations.Galactic_Republic.ToString(),
                    agility = 9,
                    wisdom = 10,
                    gender = Genders.MALE.ToString(),
                    strength = 1,
                    resilience = 7,
                    name = "Yoda",
                    homeworld = null
                },
                new Models.People() {
                    id = 3,
                    afiliation = Afiliations.Rebel_Alliance.ToString(),
                    agility = 6,
                    wisdom = 6,
                    strength = 7,
                    resilience = 4,
                    name = "Mace Windu",
                    homeworld = Stores.PlanetStore.Get(2)
                }
            };
        }
    }
}
