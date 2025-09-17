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

        #region Queries GET

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

        #region Queries SET

        private const string _queryCreateRecette =
            $"INSERT INTO {recetteTable} " +
            "(nom, description, temps_preparation, temps_cuisson, difficulte, id_utilisateur, img) " +
            "VALUES(@nom, @description, @temps_preparation, @temps_cuisson, @difficulte, @id_utilisateur, @img) " +
            "RETURNING id;";

        private const string _queryUpdateRecette =
            $"UPDATE {recetteTable} " +
            "SET nom = @nom, description = @description, temps_preparation = @temps_preparation, " +
            "temps_cuisson = @temps_cuisson, difficulte = @difficulte, img = @img " +
            "WHERE id = @id";

        private const string _queryDeleteRecette =
            $"DELETE FROM {recetteTable} " +
            "WHERE id = @id";

        #endregion

        #endregion

        #region Methods

        #region Getter

        public async Task<List<Recette>> GetAllRecettesAsync()
        {
            List<Recette> recettes = new List<Recette>();

            recettes = (await _dbSession.Connection.QueryAsync<Recette>(_queryGetAllRecettes, transaction: _dbSession.Transaction)).ToList();

            return recettes;
        }


        public async Task<Recette> GetRecetteByIdAsync(int id)
        {
            Recette recette = new Recette();

            recette = await _dbSession.Connection.QuerySingleAsync<Recette>(_queryGetRecetteById, new
            {
                Id = id
            }, transaction: _dbSession.Transaction);

            return recette;
        }

        #endregion

        #region Setter

        public async Task<int> CreateRecetteAsync(Recette recette)
        {
            int newId = await _dbSession.Connection.QuerySingleAsync<int>(_queryCreateRecette, new
            {
                nom = recette.nom,
                description = recette.description,
                temps_preparation = recette.temps_preparation,
                temps_cuisson = recette.temps_cuisson,
                difficulte = recette.difficulte,
                id_utilisateur = recette.id_utilisateur,
                img = recette.img
            }, transaction: _dbSession.Transaction);
            return newId;
        }

        public async Task<int> UpdateRecetteAsync(Recette recette)
        {
            int rowAffected = await _dbSession.Connection.ExecuteAsync(_queryUpdateRecette, new
            {
                id = recette.id,
                nom = recette.nom,
                description = recette.description,
                temps_preparation = recette.temps_preparation,
                temps_cuisson = recette.temps_cuisson,
                difficulte = recette.difficulte,
                img = recette.img
            }, transaction: _dbSession.Transaction);
            return rowAffected;
        }

        public async Task<int> DeleteRecetteAsync(int id)
        {
            int rowAffected = await _dbSession.Connection.ExecuteAsync(_queryDeleteRecette, new
            {
                id
            }, transaction: _dbSession.Transaction);
            return rowAffected;
        }

        #endregion

        #endregion
    }
}