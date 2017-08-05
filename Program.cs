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
                    poblacion = 5000,
                    nombre = "Stewjon",
                    isTieneAgua = true,
                    avatar = @"http://vignette2.wikia.nocookie.net/starwars/images/9/92/HaruunKalCSWE.JPG/revision/latest?cb=20120821183509"
                },
                new Models.Planet() {
                    id = 2,
                    afiliation = Afiliations.vieja_republica.ToString(),
                    clima = Climates.temperado.ToString(),
                    poblacion = 1000000000000,
                    nombre = "Coruscant",
                    isTieneAgua = true,
                    avatar = @"https://vignette2.wikia.nocookie.net/starwarscavalryofdarkness/images/b/bd/ImagesCA533VT4.jpg/revision/latest?cb=20110726170244"
                },
                new Models.Planet() {
                    id = 3,
                    afiliation = Afiliations.neutral.ToString(),
                    clima = Climates.unknown.ToString(),
                    nombre = "Haruun Kal",
                    poblacion = 500000,
                    isTieneAgua = false,
                    avatar = @"https://vignette4.wikia.nocookie.net/starwarscavalryofdarkness/images/1/18/ImagesCA7SQ7B6.jpg/revision/latest?cb=20110730214013"
                },
                new Models.Planet() {
                    id = 4,
                    afiliation = Afiliations.hermanos_nocturnos.ToString(),
                    clima = Climates.pantanoso.ToString(),
                    nombre = "Dathomir",
                    poblacion = 240000,
                    isTieneAgua = true,
                    avatar = @"https://vignette2.wikia.nocookie.net/starwars/images/f/f3/Dathomir-Massacre.png/revision/latest/scale-to-width-down/500?cb=20150306134751"
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
                    planeta_natal = Stores.PlanetStore.Get(1),
                    avatar = @"https://vignette4.wikia.nocookie.net/starwars/images/4/4e/ObiWanHS-SWE.jpg/revision/latest/scale-to-width-down/500?cb=20111115052816"
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
                    planeta_natal = null,
                    avatar = @"http://samequizy.pl/wp-content/uploads/2016/10/filing_images_d0f0c5c867fd.jpg"
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
                    planeta_natal = Stores.PlanetStore.Get(3),
                    avatar = @"https://pbs.twimg.com/profile_images/814236136457416704/zhn1Fwn-.jpg"
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
                    planeta_natal = Stores.PlanetStore.Get(2),
                    avatar = @"http://starwarsmoviequotes.com/wp-content/uploads/2017/03/fi-qui-gon-320x320.png"
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
                    planeta_natal = Stores.PlanetStore.Get(4),
                    avatar = @"http://maxvision.us/wp-content/uploads/2017/05/pictures-of-darth-maul-photo-300507-thumbjpg-coloring-pages.jpg"
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
                    planeta_natal = Stores.PlanetStore.Get(4),
                    avatar = @"https://s-media-cache-ak0.pinimg.com/236x/33/92/54/339254d7bb332845c5a56dd50f49b46d--sith-star-wars.jpg"
                }
            };
        }
    }
}
