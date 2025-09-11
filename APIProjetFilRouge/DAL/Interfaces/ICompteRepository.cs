using APIProjetFilRouge.Models.BussinessObjects;

namespace APIProjetFilRouge.DAL.Interfaces
{
    public interface ICompteRepository
    {
        /// <summary>
        /// Retrieves all accounts from the database.
        /// </summary>
        /// <returns>accounts</returns>
        Task<List<Compte>> GetAllComptesAsync();

        /// <summary>
        /// Retrieves an account by its ID.
        /// </summary>
        /// <param name="id">ID of the account</param>
        /// <returns>account of the user</returns>
        Task<Compte> GetCompteByIdAsync(int id);

        /// <summary>
        /// Creates a new account in the database.
        /// </summary>
        /// <param name="identifiant">pseudo of the user</param>
        /// <param name="nom">lastname of the user</param>
        /// <param name="prenom">firstname of the user</param>
        /// <param name="email">email of the user</param>
        /// <param name="password">password of the user</param>
        /// <param name="admin">is user admin?</param>
        /// <returns>id of the new account</returns>
        Task<int> CreateCompteAsync(string identifiant, string nom, string prenom, string email, string password, bool admin);

        /// <summary>
        /// Deletes an account from the database based on the account ID.
        /// </summary>
        /// <param name="id">id of the user</param>
        /// <returns>number of rows affected</returns>
        Task<int> DeleteCompteAsync(int id);
    }
}
