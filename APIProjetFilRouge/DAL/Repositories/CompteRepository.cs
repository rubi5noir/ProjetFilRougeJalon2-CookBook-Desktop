using APIProjetFilRouge.DAL.Interfaces;
using APIProjetFilRouge.Models.BussinessObjects;
using Dapper;

namespace APIProjetFilRouge.DAL.Repositories
{
    public class CompteRepository : ICompteRepository
    {
        private readonly string _connectionString;
        private const string compteTable = "utilisateurs";

        public CompteRepository(IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            if (string.IsNullOrEmpty(connectionString))
            {
                throw new ArgumentNullException("Connection string 'DefaultConnection' not found.");
            }

            _connectionString = connectionString;
        }

        #region Queries

        private const string _queryGetCompteById =
            "SELECT " +
            "id, identifiant, nom, prenom, email, password, admin " +
            $"FROM {compteTable} " +
            "WHERE id = @Id";

        #endregion

        #region Getter

        /// <summary>
        /// Retrieves an account by its ID.
        /// </summary>
        /// <param name="id">ID of the account</param>
        /// <returns></returns>
        public async Task<Compte> GetCompteById(int id)
        {
            try
            {
                Compte compte = new Compte();

                using (var connexion = new Npgsql.NpgsqlConnection(_connectionString))
                {
                    compte = await connexion.QuerySingleAsync<Compte>(_queryGetCompteById, new { Id = id });
                }
                return compte;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving the account by ID.", ex);
            }
        }

        #endregion
    }
}
