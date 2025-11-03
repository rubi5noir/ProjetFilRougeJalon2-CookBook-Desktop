using APIProjetFilRouge.Models.BussinessObjects;

namespace APIProjetFilRouge.DAL.Interfaces
{
    public interface ICategorieRepository
    {
        /// <summary>
        /// Retrieves all categories from the database.
        /// </summary>
        /// <returns><see cref="List{Categorie}"/> of <see cref="Categorie"/> : All categories</returns>
        Task<List<Categorie>> GetAllCategoriesAsync();

        /// <summary>
        /// Retrieves all categories associated with a specific recipe by the ID of the recipe.
        /// </summary>
        /// <returns><see cref="List{Categorie}"/> of <see cref="Categorie"/> : All categories of the recipe</returns>
        Task<List<Categorie>> GetCategoriesOfRecetteAsync(int id);

        /// <summary>
        /// Retrieves all recipes IDs associated with a specific category by the ID of the category.
        /// </summary>
        /// <param name="id"></param>
        /// <returns><see cref="List{int}"/> of <see cref="int"/> : All recipes IDs </returns>
        Task<List<int>> GetCategorieRelationshipsByIdAsync(int id);

        /// <summary>
        /// Creates a new categorie in the database.
        /// </summary>
        /// <returns><see cref="int"/> : Id of the new categorie</returns>
        Task<int> CreateCategorieAsync(string nom);

        /// <summary>
        /// Update a categorie from the database.
        /// </summary>
        /// <returns><see cref="int"/> : Number of rows affected</returns>
        Task<int> UpdateCategorieAsync(Categorie categorie);

        /// <summary>
        /// Deletes a categorie from the database based on the categorie ID.
        /// </summary>
        /// <returns><see cref="int"/> : Number of rows affected</returns>
        Task<int> DeleteCategorieAsync(int id);

        /// <summary>
        /// Add a categorie to a recipe from the database.
        /// </summary>
        /// <returns><see cref="int"/> : Number of rows affected</returns>
        Task<int> AddCategorieToRecetteAsync(int id_recette, Categorie categorie);

        /// <summary>
        /// Remove a categorie from a recipe from the database.
        /// </summary>
        /// <returns><see cref="int"/> : Number of rows affected</returns>
        Task<int> RemoveCategorieFromRecetteAsync(int id_recette, Categorie categorie);
    }
}
