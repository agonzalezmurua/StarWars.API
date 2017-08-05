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
                .UseUrls("http://localhost:5000;http://starwarsapi.redirectme.net")
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
                    clima = Climates.seco.ToString(),
                    population = 5000,
                    nombre = "Stewjon",
                    hasWater = true
                },
                new Models.Planet() {
                    id = 2,
                    afiliation = Afiliations.vieja_republica.ToString(),
                    clima = Climates.temperado.ToString(),
                    population = 1000000000000,
                    nombre = "Coruscant",
                    hasWater = true
                },
                new Models.Planet() {
                    id = 3,
                    afiliation = Afiliations.neutral.ToString(),
                    clima = Climates.unknown.ToString(),
                    nombre = "Haruun Kai",
                    population = 500000,
                    hasWater = false,
                },
                new Models.Planet() {
                    id = 4,
                    afiliation = Afiliations.hermanos_nocturnos.ToString(),
                    clima = Climates.pantanoso.ToString(),
                    nombre = "Dathomir",
                    population = 240000,
                    hasWater = true,
                } 
             };

            Stores.PeopleStore.Store = new List<StarWars.Models.People>()
            {
                new Models.People() {
                    id = 1,
                    afiliation = Afiliations.republica_galactica.ToString(),
                    agility = 5,
                    wisdom = 7,
                    genero = Genders.masculino.ToString(),
                    strength = 3,
                    resilience = 6,
                    nombre = "Obi-Wan Kennobi",
                    occupation = Occupations.jedi.ToString(),
                    planeta_natal = Stores.PlanetStore.Get(1)
                },
                new Models.People() {
                    id = 2,
                    afiliation = Afiliations.republica_galactica.ToString(),
                    agility = 9,
                    wisdom = 10,
                    genero = Genders.masculino.ToString(),
                    strength = 1,
                    resilience = 7,
                    nombre = "Yoda",
                    occupation = Occupations.jedi.ToString(),
                    planeta_natal = null
                },
                new Models.People() {
                    id = 3,
                    afiliation = Afiliations.alianza_rebelde.ToString(),
                    agility = 6,
                    wisdom = 6,
                    genero = Genders.masculino.ToString(),
                    strength = 7,
                    resilience = 4,
                    nombre = "Mace Windu",
                    occupation = Occupations.jedi.ToString(),
                    planeta_natal = Stores.PlanetStore.Get(3)
                },
                new Models.People() {
                    id = 4,
                    afiliation = Afiliations.republica_galactica.ToString(),
                    agility = 5,
                    wisdom = 8,
                    genero = Genders.masculino.ToString(),
                    strength = 5,
                    resilience = 6,
                    nombre = "Qui-Gon Jinn",
                    occupation = Occupations.jedi.ToString(),
                    planeta_natal = Stores.PlanetStore.Get(2)
                },
                new Models.People() {
                    id = 5,
                    afiliation = Afiliations.hermanos_nocturnos.ToString(),
                    agility = 7,
                    wisdom = 4,
                    genero = Genders.masculino.ToString(),
                    strength = 6,
                    resilience = 9,
                    nombre =  "Darth Maul",
                    occupation = Occupations.sith.ToString(),
                    planeta_natal = Stores.PlanetStore.Get(4)
                },
                new Models.People() {
                    id = 6,
                    afiliation = Afiliations.hermanas_nocturnas.ToString(),
                    agility = 9,
                    wisdom = 3,
                    genero = Genders.femenino.ToString(),
                    strength = 7,
                    resilience = 10,
                    nombre =  "Asajj Ventress",
                    occupation = Occupations.sith.ToString(),
                    planeta_natal = Stores.PlanetStore.Get(4)
                }
            };
        }
    }
}
