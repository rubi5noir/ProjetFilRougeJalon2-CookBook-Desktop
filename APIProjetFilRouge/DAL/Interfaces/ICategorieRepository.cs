using APIProjetFilRouge.Models.BussinessObjects;
using APIProjetFilRouge.Models.DataTransfertObjects.Between;

namespace APIProjetFilRouge.DAL.Interfaces
{
    public interface ICategorieRepository
    {
        /// <summary>
        /// Retrieves all categories associated with a specific recipe by the ID of the recipe.
        /// </summary>
        /// <param name="id">ID of the recipe</param>
        /// <returns></returns>
        Task<List<Categorie>> GetCategoriesOfRecetteAsync(int id);
    }
}
