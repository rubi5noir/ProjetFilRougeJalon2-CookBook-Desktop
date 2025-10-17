using APIProjetFilRouge.Models.DataTransfertObjects.Between;
using FluentValidation;

namespace APIProjetFilRouge.Models.DataTransfertObjects.In
{
#pragma warning disable S101 // Types should be named in PascalCase
    public class RecetteCreateDTO
#pragma warning restore S101 // Types should be named in PascalCase
    {
        public int id_utilisateur { get; set; }
#pragma warning disable CS8618 // Un champ non-nullable doit contenir une valeur autre que Null lors de la fermeture du constructeur. Envisagez d’ajouter le modificateur « required » ou de déclarer le champ comme pouvant accepter la valeur Null.
        public string nom { get; set; }
        public string description { get; set; }
        public int temps_preparation_heures { get; set; }
        public int temps_preparation_minutes { get; set; }
        public int temps_cuisson_heures { get; set; }
        public int temps_cuisson_minutes { get; set; }
        public int difficulte { get; set; }
        public string img { get; set; }

        public List<IngredientDTO> ingredients { get; set; }

        public List<EtapeDTO> etapes { get; set; }

        public List<CategorieDTO> categories { get; set; }
#pragma warning restore CS8618 // Un champ non-nullable doit contenir une valeur autre que Null lors de la fermeture du constructeur. Envisagez d’ajouter le modificateur « required » ou de déclarer le champ comme pouvant accepter la valeur Null.
    }



#pragma warning disable S101 // Types should be named in PascalCase
    public class RecetteCreateDTOValidator : AbstractValidator<RecetteCreateDTO>
#pragma warning restore S101 // Types should be named in PascalCase
    {
        public RecetteCreateDTOValidator()
        {
            RuleFor(r => r.id_utilisateur).GreaterThan(0).NotNull().WithMessage("Utilisateur introuvable");
            RuleFor(r => r.nom).NotEmpty().NotNull().WithMessage("Le nom de la recette est obligatoire.");
            RuleFor(r => r.description).NotEmpty().NotNull().WithMessage("La description de la recette est obligatoire.");
            RuleFor(r => r.difficulte).InclusiveBetween(1, 5).WithMessage("La difficulté doit être renseignée.");
            RuleFor(r => r.temps_preparation_heures).NotNull().WithMessage("Le temps de préparation est obligatoire.");
            RuleFor(r => r.temps_preparation_minutes).NotNull().WithMessage("Le temps de préparation est obligatoire.");
            RuleFor(r => r.temps_cuisson_heures).NotNull().WithMessage("Le temps de cuisson est obligatoire.");
            RuleFor(r => r.temps_cuisson_minutes).NotNull().WithMessage("Le temps de cuisson est obligatoire.");
            RuleFor(r => r.img).NotEmpty().NotNull().WithMessage("L'image de la recette est obligatoire.");
            RuleFor(r => r.ingredients).NotEmpty().WithMessage("Au moins un ingrédient est requis.");
            RuleFor(r => r.etapes).NotEmpty().WithMessage("Au moins une étape est requise.");
            RuleFor(r => r.categories).NotEmpty().WithMessage("Au moins une catégorie est requise.");
        }
    }
}
