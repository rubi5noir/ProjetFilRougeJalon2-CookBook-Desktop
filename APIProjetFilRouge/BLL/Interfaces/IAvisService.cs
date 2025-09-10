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
        /// <returns>
        /// <para>An AverageNoteDTO object containing a dictionary with recipe IDs as keys and their corresponding average notes as values.</para>
        /// <para>Throws an exception if an error occurs while processing the request.</para>
        /// </returns>
        public Task<List<Avis>> GetAvisOfAllRecettesAsync();

        /// <summary>
        /// Retrieves all reviews of a specific recipe by its ID.
        /// </summary>
        /// <param name="id">ID of the recipe</param>
        /// <returns></returns>
        public Task<List<Avis>> GetAvisOfRecetteAsync(int id);
    }
}
