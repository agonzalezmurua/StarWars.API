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
                    afiliation = Afiliations.neutral.ToString(),
                    climate = Climates.dry.ToString(),
                    population = 5000,
                    name = "Stewjon",
                    hasWater = true
                },
                new Models.Planet() {
                    id = 2,
                    afiliation = Afiliations.old_republic.ToString(),
                    climate = Climates.temperate.ToString(),
                    population = 1000000000000,
                    name = "Coruscant",
                    hasWater = true
                },
                new Models.Planet() {
                    id = 3,
                    afiliation = Afiliations.unknown.ToString(),
                    climate = Climates.unknown.ToString(),
                    name = "Haruun Kai",
                    population = 500000,
                    hasWater = false,
                },
                new Models.Planet() {
                    id = 4,
                    afiliation = Afiliations.nightbrothers.ToString(),
                    climate = Climates.swamp.ToString(),
                    name = "Dathomir",
                    population = 240000,
                    hasWater = true,
                } 
             };

            Stores.PeopleStore.Store = new List<StarWars.Models.People>()
            {
                new Models.People() {
                    id = 1,
                    afiliation = Afiliations.galatic_republic.ToString(),
                    agility = 5,
                    wisdom = 7,
                    gender = Genders.male.ToString(),
                    strength = 3,
                    resilience = 6,
                    name = "Obi-Wan Kennobi",
                    occupation = Occupations.jedi.ToString(),
                    homeworld = Stores.PlanetStore.Get(1)
                },
                new Models.People() {
                    id = 2,
                    afiliation = Afiliations.galatic_republic.ToString(),
                    agility = 9,
                    wisdom = 10,
                    gender = Genders.male.ToString(),
                    strength = 1,
                    resilience = 7,
                    name = "Yoda",
                    occupation = Occupations.jedi.ToString(),
                    homeworld = null
                },
                new Models.People() {
                    id = 3,
                    afiliation = Afiliations.rebel_alliance.ToString(),
                    agility = 6,
                    wisdom = 6,
                    gender = Genders.male.ToString(),
                    strength = 7,
                    resilience = 4,
                    name = "Mace Windu",
                    occupation = Occupations.jedi.ToString(),
                    homeworld = Stores.PlanetStore.Get(3)
                },
                new Models.People() {
                    id = 4,
                    afiliation = Afiliations.galatic_republic.ToString(),
                    agility = 5,
                    wisdom = 8,
                    gender = Genders.male.ToString(),
                    strength = 5,
                    resilience = 6,
                    name = "Qui-Gon Jinn",
                    occupation = Occupations.jedi.ToString(),
                    homeworld = Stores.PlanetStore.Get(2)
                },
                new Models.People() {
                    id = 5,
                    afiliation = Afiliations.nightbrothers.ToString(),
                    agility = 7,
                    wisdom = 4,
                    gender = Genders.male.ToString(),
                    strength = 6,
                    resilience = 9,
                    name =  "Darth Maul",
                    occupation = Occupations.sith.ToString(),
                    homeworld = Stores.PlanetStore.Get(4)
                },
                new Models.People() {
                    id = 6,
                    afiliation = Afiliations.nightsisters.ToString(),
                    agility = 9,
                    wisdom = 3,
                    gender = Genders.female.ToString(),
                    strength = 7,
                    resilience = 10,
                    name =  "Asajj Ventress",
                    occupation = Occupations.sith.ToString(),
                    homeworld = Stores.PlanetStore.Get(4)
                }
            };
        }
    }
}
