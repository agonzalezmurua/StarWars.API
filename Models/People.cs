namespace API.Models
{
    public class People
    {
        public int id { get; set; }
        public string name { get; set; }
        public Planet homeworld { get; set; }
        public Genders gender { get; set; }
    }
}