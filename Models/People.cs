namespace StarWars.Models
{
    public class People
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public Planet planeta_natal { get; set; }
        private Genders _genero;
        public string genero
        {
            get { return _genero.ToString();}
            set { _genero = (Genders)System.Enum.Parse(typeof(Genders),value);}
        }
        
        private Afiliations _afiliation;
        public string afiliation
        {
            get { return _afiliation.ToString();}
            set { _afiliation = (Afiliations)System.Enum.Parse(typeof(Afiliations),value);}
        }
        
        private Occupations _occupation;
        public string occupation
        {
            get { return _occupation.ToString();}
            set { _occupation = (Occupations)System.Enum.Parse(typeof(Occupations),value);}
        }
        
        public int strength { get; set; }
        public int agility { get; set; }
        public int wisdom { get; set; }
        public int resilience { get; set; }
    }
}