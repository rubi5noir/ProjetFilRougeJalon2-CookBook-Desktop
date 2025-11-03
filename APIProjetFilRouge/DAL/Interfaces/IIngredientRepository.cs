using APIProjetFilRouge.Models.BussinessObjects;

namespace APIProjetFilRouge.DAL.Interfaces
{
    public interface IIngredientRepository
    {
        /// <summary>
        /// Retrieves all ingredients from the database.
        /// </summary>
        /// <returns><see cref="List{Ingredient}"/> of <see cref="Ingredient"/> : All ingredients</returns>
        Task<List<Ingredient>> GetAllIngredientsAsync();

        /// <summary>
        /// Retrieves the list of ingredients along with their quantities for a specific recipe by the ID of the recipe.
        /// </summary>
        /// <returns><see cref="List{Ingredient}"/> of <see cref="Ingredient"/> : All ingredients of the recipe</returns>
        Task<List<Ingredient>> GetIngredientsWithQuantitiesOfRecetteAsync(int id);

        /// <summary>
        /// Retrieves the list of IDs of the recipe linked with the specified ingredient
        /// </summary>
        /// <param name="id"></param>
        /// <returns><see cref="List{int}"/> of <see cref="int"/> : IDs of the recipes</returns>
        Task<List<int>> GetRecettesIDsFromIngredientAsync(int id);

        /// <summary>
        /// Creates a new ingredient in the database.
        /// </summary>
        /// <returns><see cref="int"/> : Id of the new ingredient</returns>
        Task<int> CreateIngredientAsync(Ingredient ingredient);

        /// <summary>
        /// Deletes an ingredient from the database.
        /// </summary>
        /// <returns><see cref="int"/> : Number of rows affected</returns>
        Task<int> UpdateIngredientAsync(Ingredient ingredient);

        /// <summary>
        /// Deletes an ingredient from the database based on the ingredient ID.
        /// </summary>
        /// <returns><see cref="int"/> : Number of rows affected</returns>
        Task<int> DeleteIngredientAsync(int id);

        /// <summary>
        /// Add an ingredient to a recipe from the database.
        /// </summary>
        /// <returns><see cref="int"/> : Number of rows affected</returns>
        Task<int> AddIngredientToRecetteAsync(int id_recette, Ingredient ingredient);

        /// <summary>
        /// Remove an ingredient from a recipe from the database.
        /// </summary>
        /// <returns><see cref="int"/> : Number of rows affected</returns>
        Task<int> RemoveIngredientFromRecetteAsync(int id_recette, Ingredient ingredient);
    }
}
