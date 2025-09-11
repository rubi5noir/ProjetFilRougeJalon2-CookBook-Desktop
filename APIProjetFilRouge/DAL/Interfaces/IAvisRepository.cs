using APIProjetFilRouge.Models.BussinessObjects;

namespace APIProjetFilRouge.DAL.Interfaces
{
    public interface IAvisRepository
    {
        /// <summary>
        /// Retrieves all reviews from the database.
        /// </summary>
        /// <returns>reviews</returns>
        Task<List<Avis>> GetAllAvisAsync();

        /// <summary>
        /// Retrieves all reviews of a specific recipe by its ID.
        /// </summary>
        /// <param name="id">ID of the recipe</param>
        /// <returns>reviews of the recipe</returns>
        Task<List<Avis>> GetAvisByRecetteIdAsync(int idRecette);

        /// <summary>
        /// Creates a new review in the database.
        /// </summary>
        /// <param name="avis">review to create</param>
        /// <returns>id of the new review</returns>
        Task<int> CreateAvisAsync(Avis avis);

        /// <summary>
        /// Deletes a review from the database based on the recipe ID and user ID.
        /// </summary>
        /// <param name="id_recette">id of the recipe</param>
        /// <param name="id_utilisateur">id of the review's owner</param>
        /// <returns>number of rows affected</returns>
        Task<int> DeleteAvisAsync(int id_recette, int id_utilisateur);
    }
}
