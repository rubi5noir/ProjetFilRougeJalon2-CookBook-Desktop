using APIProjetFilRouge.Models.BussinessObjects;

namespace APIProjetFilRouge.DAL.Interfaces
{
    public interface IRecetteRepository
    {
        /// <summary>
        /// Retrieves all recipes from the database.
        /// </summary>
        /// <returns>
        /// <para>A list of Recette objects representing all recipes.</para>
        /// <para>Throws an exception if an error occurs while retrieving the recipes.</para>
        /// </returns>
        Task<List<Recette>> GetAllRecettesAsync();

        /// <summary>
        /// Retrieves a specific recipe by its ID.
        /// </summary>
        /// <param name="id">ID of the recipe</param>
        /// <returns></returns>
        Task<Recette> GetRecetteByIdAsync(int id);

        /// <summary>
        /// Creates a new recipe in the database.
        /// </summary>
        /// <param name="recette">recipe to create</param>
        /// <returns>id of the recipe</returns>
        Task<int> CreateRecetteAsync(Recette recette);

        /// <summary>
        /// Updates an existing recipe in the database.
        /// </summary>
        /// <param name="recette">recipe to put in the database</param>
        /// <returns>number of rows affected</returns>
        Task<int> UpdateRecetteAsync(Recette recette);

        /// <summary>
        /// Deletes a recipe from the database based on the recipe ID.
        /// </summary>
        /// <param name="id">id of the recipe</param>
        /// <returns>number of rows affected</returns>
        Task<int> DeleteRecetteAsync(int id);
    }
}
