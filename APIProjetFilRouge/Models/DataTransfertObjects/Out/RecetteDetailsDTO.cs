using APIProjetFilRouge.Models.BussinessObjects;
using APIProjetFilRouge.Models.DataTransfertObjects.Between;

namespace APIProjetFilRouge.Models.DataTransfertObjects.Out
{
    public class RecetteDetailsDTO
    {
        public int id { get; set; }
        public string identifiantCreateur { get; set; } = "";
        public string nom { get; set; }
        public string description { get; set; }
        public TimeSpan temps_preparation { get; set; }
        public TimeSpan temps_cuisson { get; set; }
        public TimeSpan temps_total { get { return temps_preparation + temps_cuisson; } }
        public int difficulte { get; set; }


        public List<IngredientDTO> ingredients { get; set; }

        public List<EtapeDTO> etapes { get; set; }

        public List<CategorieDTO> categories { get; set; }

        //public Compte? utilisateur { get; set; }

        public List<AvisOfRecetteDTO> avis { get; set; }


        public string? img { get; set; } // pour l'affichage

        //public IFormFile imgFile { get; set; } // pour le formulaire

        /* Nouvel avis */
        //public string aviscommentaire { get; set; }
        //public double avisnote { get; set; }
    }
}
