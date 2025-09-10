using APIProjetFilRouge.Models.DataTransfertObjects.Between;

namespace APIProjetFilRouge.Models.DataTransfertObjects.In
{
    public class RecetteCreateDTO
    {
        public int id_utilisateur { get; set; }
        public string nom { get; set; }
        public string description { get; set; }
        public TimeSpan temps_preparation { get; set; }
        public TimeSpan temps_cuisson { get; set; }
        public int difficulte { get; set; }
        public string img { get; set; }

        public List<IngredientDTO> ingredients { get; set; }

        public List<EtapeDTO> etapes { get; set; }

        public List<CategorieDTO> categories { get; set; }
    }
}
