using APIProjetFilRouge.Models.BussinessObjects;

namespace APIProjetFilRouge.DAL.Interfaces
{
    public interface IAvisRepository
    {
        /// <summary>
        /// Retrieves all reviews from the database.
        /// </summary>
        /// <returns>
        /// <para>A list of Avis objects representing all reviews.</para>
        /// <para>Throws an exception if an error occurs while retrieving the reviews.</para>
        /// </returns>
        public Task<List<Avis>> GetAllAvisAsync();

        /// <summary>
        /// Retrieves all reviews of a specific recipe by its ID.
        /// </summary>
        /// <param name="id">ID of the recipe</param>
        /// <returns></returns>
        public Task<List<Avis>> GetAvisByRecetteIdAsync(int idRecette);
    }
}
