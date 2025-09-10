using APIProjetFilRouge.Models.BussinessObjects;

namespace APIProjetFilRouge.DAL.Interfaces
{
    public interface IEtapeRepository
    {
        /// <summary>
        /// Retrieves all steps for a specific recipe by the ID of the recipe.
        /// </summary>
        /// <param name="id">ID of the recipe</param>
        /// <returns></returns>
        Task<List<Etape>> GetEtapesOfRecetteAsync(int id);
    }
}
