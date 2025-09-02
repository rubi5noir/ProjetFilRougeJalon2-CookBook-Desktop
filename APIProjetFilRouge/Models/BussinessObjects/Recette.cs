namespace APIProjetFilRouge.Models.BussinessObjects
{
    public class Recette
    {
        public int id { get; set; }
        public int id_utilisateur { get; set; }
        public string nom { get; set; }
        public string description { get; set; }
        public TimeSpan temps_preparation { get; set; }
        public TimeSpan temps_cuisson { get; set; }
        public int difficulte { get; set; }
        public string img { get; set; } 

    }
}
