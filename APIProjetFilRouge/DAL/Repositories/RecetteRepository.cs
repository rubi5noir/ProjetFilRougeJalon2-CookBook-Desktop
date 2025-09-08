using APIProjetFilRouge.Models.BussinessObjects;
using Npgsql;
using Dapper;
using System.Security.Claims;
using APIProjetFilRouge.DAL.Interfaces;

namespace APIProjetFilRouge.DAL.Repositories
{
    public class RecetteRepository : IRecetteRepository
    {
        private readonly string _connectionString;
        private const string recetteTable = "recettes";

        public RecetteRepository(IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            if (string.IsNullOrEmpty(connectionString))
            {
                throw new ArgumentNullException("Connection string 'DefaultConnection' not found.");
            }

            _connectionString = connectionString;
        }

        #region Queries

        private const string _queryGetAllRecettes =
            "SELECT " +
            "id, nom, description, temps_preparation, temps_cuisson, difficulte, id_utilisateur, img " +
            $"FROM {recetteTable}";

        private const string _queryGetRecetteById =
            "SELECT " +
            "id, nom, description, temps_preparation, temps_cuisson, difficulte, id_utilisateur, img " +
            $"FROM {recetteTable} " +
            "WHERE id = @Id";

        #endregion

        #region Getter

        /// <summary>
        /// Retrieves all recipes from the database.
        /// </summary>
        /// <returns>
        /// <para>A list of Recette objects representing all recipes.</para>
        /// <para>Throws an exception if an error occurs while retrieving the recipes.</para>
        /// </returns>
        public async Task<List<Recette>> GetAllRecettes()
        {
            try
            {
                List<Recette> recettes = new List<Recette>();
                using (var connexion = new NpgsqlConnection(_connectionString))
                {
                    recettes = (await connexion.QueryAsync<Recette>(_queryGetAllRecettes)).ToList();
                }
                return recettes;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving all recipes.", ex);
            }
        }


        /// <summary>
        /// Retrieves a specific recipe by its ID.
        /// </summary>
        /// <param name="id">ID of the recipe</param>
        /// <returns></returns>
        public async Task<Recette> GetRecetteById(int id)
        {
            Recette recette = new Recette();
            using (var connexion = new NpgsqlConnection(_connectionString))
            {
                recette = await connexion.QuerySingleAsync<Recette>(_queryGetRecetteById, new { Id = id });
            }
            return recette;
        }

        #endregion
    }
}