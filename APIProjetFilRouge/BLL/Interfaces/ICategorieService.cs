using APIProjetFilRouge.Models.BussinessObjects;
using APIProjetFilRouge.Models.DataTransfertObjects.Between;

namespace APIProjetFilRouge.BLL.Interfaces
{
    public interface ICategorieService
    {
        Task<List<Categorie>> GetAllCategoriesAsync();

        /// <summary>
        /// Retrieves all categories associated with a specific recipe by the ID of the recipe.
        /// </summary>
        /// <param name="id">ID of the recipe</param>
        /// <returns></returns>
        Task<List<Categorie>> GetCategoriesOfRecetteAsync(int id);

        Task<int> CreateCategorieAsync(string nom);

        Task<int> DeleteCategorieAsync(int id);
    }
}
