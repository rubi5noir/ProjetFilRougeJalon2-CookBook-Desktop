using APIProjetFilRouge.DAL.Interfaces;
using APIProjetFilRouge.Models.BussinessObjects;
using APIProjetFilRouge.Models.DataTransfertObjects.Between;

namespace APIProjetFilRouge.BLL.Interfaces
{
    public interface IAvisService
    {
        /// <summary>
        /// Retrieves the average note for all recipes.
        /// </summary>
        /// <returns>avis of all recipe</returns>
        Task<List<Avis>> GetAvisOfAllRecettesAsync();

        /// <summary>
        /// Retrieves all reviews of a specific recipe by its ID.
        /// </summary>
        /// <param name="id">ID of the recipe</param>
        /// <returns>avis of the recipe</returns>
        Task<List<Avis>> GetAvisOfRecetteAsync(int id);

        /// <summary>
        /// Creates a new review in the database.
        /// </summary>
        /// <param name="avis"></param>
        /// <returns></returns>
        Task<int> CreateAvisAsync(Avis avis);

        /// <summary>
        /// Deletes a review from the database based on the recipe ID and user ID.
        /// </summary>
        /// <param name="id_recette"></param>
        /// <param name="id_utilisateur"></param>
        /// <returns></returns>
        Task<int> DeleteAvisAsync(int id_recette, int id_utilisateur);
    }
}
