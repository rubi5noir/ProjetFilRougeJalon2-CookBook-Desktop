using APIProjetFilRouge.Models.DataTransfertObjects.Between;

namespace APIProjetFilRouge.BLL.Interfaces
{
    public interface IIngredientService
    {
        Task<List<IngredientDTO>> GetIngredientsWithQuantitiesOfRecette(int id);
    }
}
