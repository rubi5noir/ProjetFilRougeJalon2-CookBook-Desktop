using APIProjetFilRouge.Models.BussinessObjects;
using APIProjetFilRouge.Models.DataTransfertObjects.Between;

namespace APIProjetFilRouge.DAL.Interfaces
{
    public interface IIngredientRepository
    {
        Task<List<Ingredient>> GetAllIngredientsAsync();

        /// <summary>
        /// Retrieves the list of ingredients along with their quantities for a specific recipe by the ID of the recipe.
        /// </summary>
        /// <param name="id">ID of the recipe</param>
        /// <returns></returns>
        Task<List<Ingredient>> GetIngredientsWithQuantitiesOfRecetteAsync(int id);
    }
}
