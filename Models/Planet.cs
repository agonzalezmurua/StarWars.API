namespace API.Models
{
    public class Planet
    {
        public int id { get; set; }
        public string name { get; set; }
        public Climates climate { get; set; }
        public Afiliations afiliation { get; set; }
        public int population { get; set; }
        public bool hasWater { get; set; }

    }
}