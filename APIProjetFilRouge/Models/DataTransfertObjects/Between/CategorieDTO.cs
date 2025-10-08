using FluentValidation;

namespace APIProjetFilRouge.Models.DataTransfertObjects.Between
{
    public class CategorieDTO
    {
        public int id { get; set; }
        public string nom { get; set; }
    }

    public class ValidatorCategorieDTO : AbstractValidator<CategorieDTO>
    {
        public ValidatorCategorieDTO()
        {
            RuleFor(c => c.id).GreaterThanOrEqualTo(0);
            RuleFor(c => c.nom).NotEmpty();
        }
    }
}
