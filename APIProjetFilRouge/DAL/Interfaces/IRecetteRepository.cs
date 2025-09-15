using APIProjetFilRouge.Models.BussinessObjects;

namespace APIProjetFilRouge.DAL.Interfaces
{
    public interface IRecetteRepository
    {
        /// <summary>
        /// Retrieves all recipes from the database.
        /// </summary>
        /// <returns><see cref="List{Recette}"/> of <see cref="Recette"/> : All recipes</returns>
        Task<List<Recette>> GetAllRecettesAsync();

        /// <summary>
        /// Retrieves a specific recipe by its ID.
        /// </summary>
        /// <returns><see cref="Recette"/> : The recipe</returns>
        Task<Recette> GetRecetteByIdAsync(int id);

        /// <summary>
        /// Creates a new recipe in the database.
        /// </summary>
        /// <returns><see cref="int"/> : Id of the new recipe</returns>
        Task<int> CreateRecetteAsync(Recette recette);

        /// <summary>
        /// Updates an existing recipe in the database.
        /// </summary>
        /// <returns><see cref="int"/> : Number of rows affected</returns>
        Task<int> UpdateRecetteAsync(Recette recette);

        /// <summary>
        /// Deletes a recipe from the database based on the recipe ID.
        /// </summary>
        /// <returns><see cref="int"/> : Number of rows affected</returns>
        Task<int> DeleteRecetteAsync(int id);
    }
}
