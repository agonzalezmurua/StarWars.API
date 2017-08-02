namespace StarWars.Models
{
    public class Planet
    {
        public int id { get; set; }
        public string name { get; set; }
        private Climates _climate;
        public string climate
        {
            get { return _climate.ToString();}
            set { _climate = (Climates)System.Enum.Parse(typeof(Climates),value);}
        }
        private Afiliations _afiliation;
        public string afiliation
        {
            get { return _afiliation.ToString();}
            set { _afiliation = (Afiliations)System.Enum.Parse(typeof(Afiliations),value);}
        }
        public long population { get; set; }
        public bool hasWater { get; set; }

    }
}