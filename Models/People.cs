namespace API.Models
{
    public class People
    {
        public int id { get; set; }
        public string name { get; set; }
        public Planet homeworld { get; set; }
        public Genders gender { get; set; }

        public int strength { get; set; }
        public int agility { get; set; }
        public int wisdom { get; set; }
        public int resilience { get; set; }
    }
}