using APIProjetFilRouge.Models.BussinessObjects;

namespace APIProjetFilRouge.DAL.Interfaces
{
    public interface IEtapeRepository
    {
        /// <summary>
        /// Retrieves all steps from the database.
        /// </summary>
        /// <returns><see cref="List{Etape}"/> of <see cref="Etape"/> : All existing steps</returns>
        Task<List<Etape>> GetAllEtapesAsync();

        /// <summary>
        /// Retrieves all steps for a specific recipe by the ID of the recipe.
        /// </summary>
        /// <returns><see cref="List{Etape}"/> of <see cref="Etape"/> : All Steps of the recipe</returns>
        Task<List<Etape>> GetEtapesOfRecetteAsync(int id);

        /// <summary>
        /// Creates a new step in the database.
        /// </summary>
        /// <returns><see cref="int"/> : Number of rows affected</returns>
        Task<int> CreateEtapeAsync(Etape etape);

        /// <summary>
        /// Deletes a step from the database.
        /// </summary>
        /// <returns><see cref="int"/> : Number of rows affected</returns>
        Task<int> UpdateEtapeAsync(int num, Etape etape);

        /// <summary>
        /// Deletes a step from the database based on the recipe ID and step number.
        /// </summary>
        /// <returns><see cref="int"/> : Number of rows affected</returns>
        Task<int> DeleteEtapeAsync(int id_recette, int numero);
    }
}
