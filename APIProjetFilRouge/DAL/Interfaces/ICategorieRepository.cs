using APIProjetFilRouge.Models.BussinessObjects;
using APIProjetFilRouge.Models.DataTransfertObjects.Between;

namespace APIProjetFilRouge.DAL.Interfaces
{
    public interface ICategorieRepository
    {
        /// <summary>
        /// Retrieves all categories from the database.
        /// </summary>
        /// <returns>categories</returns>
        Task<List<Categorie>> GetAllCategoriesAsync();

        /// <summary>
        /// Retrieves all categories associated with a specific recipe by the ID of the recipe.
        /// </summary>
        /// <param name="id">ID of the recipe</param>
        /// <returns>categories of the recipe</returns>
        Task<List<Categorie>> GetCategoriesOfRecetteAsync(int id);

        /// <summary>
        /// Creates a new categorie in the database.
        /// </summary>
        /// <param name="nom">name of the categorie</param>
        /// <returns>id of the new categorie</returns>
        Task<int> CreateCategorieAsync(string nom);

        /// <summary>
        /// Deletes a categorie from the database based on the categorie ID.
        /// </summary>
        /// <param name="id">id of the categorie</param>
        /// <returns>number of rows affected</returns>
        Task<int> DeleteCategorieAsync(int id);
    }
}
