using APIProjetFilRouge.DAL.Interfaces;
using APIProjetFilRouge.DAL.Session;
using APIProjetFilRouge.Models.BussinessObjects;
using Dapper;
using Npgsql;
using System.Security.Claims;

namespace APIProjetFilRouge.DAL.Repositories
{
    public class RecetteRepository : IRecetteRepository
    {
        private const string recetteTable = "recettes";

        readonly IDBSession _dbSession;
        public RecetteRepository(IDBSession dbSession)
        {
            _dbSession = dbSession;
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

        public async Task<List<Recette>> GetAllRecettesAsync()
        {
            List<Recette> recettes = new List<Recette>();

            recettes = (await _dbSession.Connection.QueryAsync<Recette>(_queryGetAllRecettes)).ToList();

            return recettes;
        }


        public async Task<Recette> GetRecetteByIdAsync(int id)
        {
            Recette recette = new Recette();

            recette = await _dbSession.Connection.QuerySingleAsync<Recette>(_queryGetRecetteById, new { Id = id });

            return recette;
        }

        #endregion
    }
}