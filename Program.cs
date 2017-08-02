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
                    population = 1000000000000,
                    name = "Coruscant",
                    hasWater = true
                },
                new Models.Planet() {
                    id = 3,
                    afiliation = Afiliations.Unknown.ToString(),
                    climate = Climates.Unknown.ToString(),
                    name = "Haruun Kai",
                    population = 500000,
                    hasWater = false,
                },
                new Models.Planet() {
                    id = 4,
                    afiliation = Afiliations.Nightbrothers.ToString(),
                    climate = Climates.Swamp.ToString(),
                    name = "Dathomir",
                    population = 240000,
                    hasWater = true,
                } 
             };

            Stores.PeopleStore.Store = new List<StarWars.Models.People>()
            {
                new Models.People() {
                    id = 1,
                    afiliation = Afiliations.Galactic_Republic.ToString(),
                    agility = 5,
                    wisdom = 7,
                    gender = Genders.male.ToString(),
                    strength = 3,
                    resilience = 6,
                    name = "Obi-Wan Kennobi",
                    occupation = Occupations.Jedi.ToString(),
                    homeworld = Stores.PlanetStore.Get(1)
                },
                new Models.People() {
                    id = 2,
                    afiliation = Afiliations.Galactic_Republic.ToString(),
                    agility = 9,
                    wisdom = 10,
                    gender = Genders.male.ToString(),
                    strength = 1,
                    resilience = 7,
                    name = "Yoda",
                    occupation = Occupations.Jedi.ToString(),
                    homeworld = null
                },
                new Models.People() {
                    id = 3,
                    afiliation = Afiliations.Rebel_Alliance.ToString(),
                    agility = 6,
                    wisdom = 6,
                    gender = Genders.male.ToString(),
                    strength = 7,
                    resilience = 4,
                    name = "Mace Windu",
                    occupation = Occupations.Jedi.ToString(),
                    homeworld = Stores.PlanetStore.Get(3)
                },
                new Models.People() {
                    id = 4,
                    afiliation = Afiliations.Galactic_Republic.ToString(),
                    agility = 5,
                    wisdom = 8,
                    gender = Genders.male.ToString(),
                    strength = 5,
                    resilience = 6,
                    name = "Qui-Gon Jinn",
                    occupation = Occupations.Jedi.ToString(),
                    homeworld = Stores.PlanetStore.Get(2)
                },
                new Models.People() {
                    id = 5,
                    afiliation = Afiliations.Nightbrothers.ToString(),
                    agility = 7,
                    wisdom = 4,
                    gender = Genders.male.ToString(),
                    strength = 6,
                    resilience = 9,
                    name =  "Darth Maul",
                    occupation = Occupations.Sith.ToString(),
                    homeworld = Stores.PlanetStore.Get(4)
                },
                new Models.People() {
                    id = 6,
                    afiliation = Afiliations.Nightsisters.ToString(),
                    agility = 9,
                    wisdom = 3,
                    gender = Genders.female.ToString(),
                    strength = 7,
                    resilience = 10,
                    name =  "Asajj Ventress",
                    occupation = Occupations.Sith.ToString(),
                    homeworld = Stores.PlanetStore.Get(4)
                }
            };
        }
    }
}
