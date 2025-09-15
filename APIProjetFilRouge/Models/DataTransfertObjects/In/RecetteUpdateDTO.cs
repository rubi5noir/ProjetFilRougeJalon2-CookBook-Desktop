using APIProjetFilRouge.Models.DataTransfertObjects.Between;
using FluentValidation;

namespace APIProjetFilRouge.Models.DataTransfertObjects.In
{
    public class RecetteUpdateDTO
    {
        public int id { get; set; }
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


    public class RecetteUpdateDTOValidator : AbstractValidator<RecetteUpdateDTO>
    {
        public RecetteUpdateDTOValidator()
        {
            RuleFor(r => r.id).GreaterThan(0).NotNull().WithMessage("Recette introuvable");
            RuleFor(r => r.nom).NotEmpty().NotNull().WithMessage("Le nom de la recette est obligatoire.");
            RuleFor(r => r.description).NotEmpty().NotNull().WithMessage("La description de la recette est obligatoire.");
            RuleFor(r => r.difficulte).InclusiveBetween(1, 5).WithMessage("La difficulté doit être renseignée.");
            RuleFor(r => r.temps_preparation).NotNull().WithMessage("Le temps de préparation est obligatoire.");
            RuleFor(r => r.temps_cuisson).NotNull().WithMessage("Le temps de cuisson est obligatoire.");
            RuleFor(r => r.img).NotEmpty().NotNull().WithMessage("L'image de la recette est obligatoire.");
            RuleFor(r => r.ingredients).NotEmpty().WithMessage("Au moins un ingrédient est requis.");
            RuleFor(r => r.etapes).NotEmpty().WithMessage("Au moins une étape est requise.");
            RuleFor(r => r.categories).NotEmpty().WithMessage("Au moins une catégorie est requise.");
        }
    }
}
