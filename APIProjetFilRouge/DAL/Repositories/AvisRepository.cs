using APIProjetFilRouge.DAL.Interfaces;
using APIProjetFilRouge.Models.BussinessObjects;
using Dapper;
using Npgsql;

namespace APIProjetFilRouge.DAL.Repositories
{
    public class AvisRepository : IAvisRepository
    {
        private readonly string _connectionString;
        private const string avisTable = "avis";

        public AvisRepository(IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            if (string.IsNullOrEmpty(connectionString))
            {
                throw new ArgumentNullException("Connection string 'DefaultConnection' not found.");
            }

            _connectionString = connectionString;
        }

        private const string _queryGetAllAvis =
            "SELECT " +
            "id_recette, id_utilisateur, note, commentaire " +
            $"FROM {avisTable}";

        private const string _queryGetAvisByRecetteId =
            "SELECT " +
            "id_recette, id_utilisateur, note, commentaire " +
            $"FROM {avisTable} " +
            "WHERE id_recette = @Id";

        /// <summary>
        /// Retrieves all reviews from the database.
        /// </summary>
        /// <returns>
        /// <para>A list of Avis objects representing all reviews.</para>
        /// <para>Throws an exception if an error occurs while retrieving the reviews.</para>
        /// </returns>
        public async Task<List<Avis>> GetAllAvis()
        {
            try
            {
                List<Avis> Avis = new List<Avis>();
                using (var connexion = new NpgsqlConnection(_connectionString))
                {
                    Avis = (await connexion.QueryAsync<Avis>(_queryGetAllAvis)).ToList();
                }
                return Avis;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving all reviews.", ex);
            }
        }

        public async Task<List<Avis>> GetAvisByRecetteId(int id)
        {
            try
            {
                List<Avis> Avis = new List<Avis>();
                using (var connexion = new NpgsqlConnection(_connectionString))
                {
                    Avis = (await connexion.QueryAsync<Avis>(_queryGetAvisByRecetteId, new {Id = id})).ToList();
                }
                return Avis;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving all reviews.", ex);
            }
        }
    }
}
