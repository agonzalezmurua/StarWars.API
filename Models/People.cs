namespace StarWars.Models
{
    public class People
    {
        public int id { get; set; }
        public string name { get; set; }
        public Planet homeworld { get; set; }
        private Genders _gender;
        public string gender
        {
            get { return _gender.ToString();}
            set { _gender = (Genders)System.Enum.Parse(typeof(Genders),value);}
        }
        
        private Afiliations _afiliation;
        public string afiliation
        {
            get { return _afiliation.ToString();}
            set { _afiliation = (Afiliations)System.Enum.Parse(typeof(Afiliations),value);}
        }
        
        public int strength { get; set; }
        public int agility { get; set; }
        public int wisdom { get; set; }
        public int resilience { get; set; }
    }
}