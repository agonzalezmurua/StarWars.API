namespace StarWars.Models
{
    public class Planet
    {
        public int id { get; set; }
        public string nombre { get; set; }
        private Climates _clima;
        public string clima
        {
            get { return _clima.ToString();}
            set { _clima = (Climates)System.Enum.Parse(typeof(Climates),value);}
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