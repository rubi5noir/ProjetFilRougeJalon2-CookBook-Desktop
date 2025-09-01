using APIProjetFilRouge.Models.BussinessObjects;
using Npgsql;
using Dapper;
using System.Security.Claims;
using APIProjetFilRouge.DAL.Interfaces;

namespace APIProjetFilRouge.DAL.Repositories
{
    public class RecetteRepository : IRecetteRepository
    {
        private readonly string _connectionString = "Server=localhost;database=CookBook;uid=postgres;Pwd=password;Port=5435";

        #region Queries

        private readonly string _queryGetAllRecettes =
            "SELECT " +
            "id, nom, description, temps_preparation, temps_cuisson, difficulte, id_utilisateur, img " +
            "FROM recettes";

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

        #endregion
    }
}