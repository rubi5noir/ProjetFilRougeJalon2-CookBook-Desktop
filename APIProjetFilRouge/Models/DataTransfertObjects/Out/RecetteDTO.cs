using APIProjetFilRouge.Models.DataTransfertObjects.Between;

namespace APIProjetFilRouge.Models.DataTransfertObjects.Out
{
    public class RecetteDTO
    {
        public int id { get; set; }
        public string nom { get; set; }
        public string description { get; set; }
        public TimeSpan temps_preparation { get; set; }
        public TimeSpan temps_cuisson { get; set; }
        public TimeSpan temps_total { get { return temps_preparation + temps_cuisson; } }
        public int difficulte { get; set; }


        public string? img { get; set; } // pour l'affichage
    }
}
