using APIProjetFilRouge.Models.BussinessObjects;

namespace APIProjetFilRouge.DAL.Interfaces
{
    public interface ICompteRepository
    {
        /// <summary>
        /// Retrieves all accounts from the database.
        /// </summary>
        /// <returns><see cref="List{Compte}"/> of <see cref="Compte"/> : All accounts</returns>
        Task<List<Compte>> GetAllComptesAsync();

        /// <summary>
        /// Retrieves an account by its ID.
        /// </summary>
        /// <returns><see cref="List{Compte}"/> of <see cref="Compte"/> : All account of the user</returns>
        Task<Compte> GetCompteByIdAsync(int id);

        /// <summary>
        /// Creates a new account in the database.
        /// </summary>
        /// <returns><see cref="int"/> : Id of the new account</returns>
        Task<int> CreateCompteAsync(Compte compte);

        /// <summary>
        /// Update an account from the database.
        /// </summary>
        /// <returns><see cref="int"/> : Number of rows affected</returns>
        Task<int> UpdateCompteAsync(Compte compte);

        /// <summary>
        /// Deletes an account from the database based on the account ID.
        /// </summary>
        /// <returns><see cref="int"/> : Number of rows affected</returns>
        Task<int> DeleteCompteAsync(int id);
    }
}
