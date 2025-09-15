using APIProjetFilRouge.Models.BussinessObjects;

namespace APIProjetFilRouge.DAL.Interfaces
{
    public interface IAvisRepository
    {
        /// <summary>
        /// Retrieves all reviews from the database.
        /// </summary>
        /// <returns><see cref="List{Avis}"/> of <see cref="Avis"/> : All reviews</returns>
        Task<List<Avis>> GetAllAvisAsync();

        /// <summary>
        /// Retrieves all reviews of a specific recipe by its ID.
        /// </summary>
        /// <returns><see cref="List{Avis}"/> of <see cref="Avis"/> : All reviews of the recipe</returns>
        Task<List<Avis>> GetAvisByRecetteIdAsync(int idRecette);

        /// <summary>
        /// Creates a new review in the database.
        /// </summary>
        /// <returns><see cref="int"/> : Id of the new review</returns>
        Task<int> CreateAvisAsync(Avis avis);

        /// <summary>
        /// Deletes a review from the database based on the recipe ID and user ID.
        /// </summary>
        /// <returns><see cref="int"/> : Number of rows affected</returns>
        Task<int> DeleteAvisAsync(int id_recette, int id_utilisateur);
    }
}
