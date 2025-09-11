using APIProjetFilRouge.Models.BussinessObjects;
using APIProjetFilRouge.Models.DataTransfertObjects.Between;

namespace APIProjetFilRouge.DAL.Interfaces
{
    public interface IIngredientRepository
    {
        /// <summary>
        /// Retrieves all ingredients from the database.
        /// </summary>
        /// <returns>ingredients</returns>
        Task<List<Ingredient>> GetAllIngredientsAsync();

        /// <summary>
        /// Retrieves the list of ingredients along with their quantities for a specific recipe by the ID of the recipe.
        /// </summary>
        /// <param name="id">ID of the recipe</param>
        /// <returns>ingredients of the recipe</returns>
        Task<List<Ingredient>> GetIngredientsWithQuantitiesOfRecetteAsync(int id);

        /// <summary>
        /// Creates a new ingredient in the database.
        /// </summary>
        /// <param name="ingredient">ingredient to create</param>
        /// <returns>id of the new ingredient</returns>
        Task<int> CreateIngredientAsync(Ingredient ingredient);

        /// <summary>
        /// Deletes an ingredient from the database based on the ingredient ID.
        /// </summary>
        /// <param name="id">id of the ingredient</param>
        /// <returns>number of rows affected</returns>
        Task<int> DeleteIngredientAsync(int id);
    }
}
