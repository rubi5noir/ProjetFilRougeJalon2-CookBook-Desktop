using APIProjetFilRouge.DAL.Interfaces;
using APIProjetFilRouge.Models.BussinessObjects;
using Dapper;

namespace APIProjetFilRouge.DAL.Repositories
{
    public class EtapeRepository : IEtapeRepository
    {
        private readonly string _connectionString;
        private const string etapeTable = "etapes";

        public EtapeRepository(IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new ArgumentNullException("Connection string 'DefaultConnection' not found.");
            }
            _connectionString = connectionString;
        }

        #region Queries

        private const string _queryGetEtapesOfRecette =
            "SELECT " +
            "numero, id_recette, texte " +
            $"FROM {etapeTable} " +
            "WHERE id_recette = @IdRecette " +
            "ORDER BY numero";

        #endregion

        #region Getter

        /// <summary>
        /// Retrieves all steps for a specific recipe by the ID of the recipe.
        /// </summary>
        /// <param name="id">ID of the recipe</param>
        /// <returns></returns>
        public async Task<List<Etape>> GetEtapesOfRecette(int id)
        {
            try
            {
                List<Etape> etapes;

                using (var connexion = new Npgsql.NpgsqlConnection(_connectionString))
                {
                    etapes = (await connexion.QueryAsync<Etape>(_queryGetEtapesOfRecette, new { IdRecette = id })).ToList();
                }
                return etapes;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving steps for the recipe.", ex);
            }
        }

        #endregion
    }
}
