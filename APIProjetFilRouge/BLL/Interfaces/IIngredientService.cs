using APIProjetFilRouge.Models.BussinessObjects;
using APIProjetFilRouge.Models.DataTransfertObjects.Between;

namespace APIProjetFilRouge.BLL.Interfaces
{
    public interface IIngredientService
    {
        Task<List<Ingredient>> GetAllIngredientsAsync();

        /// <summary>
        /// Retrieves all ingredients with their quantities for a specific recipe by the ID of the recipe.
        /// </summary>
        /// <param name="id">ID of the recipe</param>
        /// <returns></returns>
        Task<List<Ingredient>> GetIngredientsWithQuantitiesOfRecetteAsync(int id);

        Task<int> CreateIngredientAsync(Ingredient ingredient);

        Task<int> DeleteIngredientAsync(int id);
    }
}
