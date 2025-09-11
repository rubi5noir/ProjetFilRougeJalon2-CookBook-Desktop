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

        /// <summary>
        /// Creates a new step in the database.
        /// </summary>
        /// <param name="etape">step to create</param>
        /// <returns>number of rows affected</returns>
        Task<int> CreateEtapeAsync(Etape etape);

        /// <summary>
        /// Deletes a step from the database based on the recipe ID and step number.
        /// </summary>
        /// <param name="id_recette">id of the recipe</param>
        /// <param name="numero">number of the step</param>
        /// <returns>number of rows affected</returns>
        Task<int> DeleteEtapeAsync(int id_recette, int numero);
    }
}
