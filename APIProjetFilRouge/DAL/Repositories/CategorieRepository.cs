using APIProjetFilRouge.DAL.Interfaces;
using APIProjetFilRouge.DAL.Session;
using APIProjetFilRouge.Models.BussinessObjects;
using Dapper;
using System.Runtime.CompilerServices;

namespace APIProjetFilRouge.DAL.Repositories
{
    public class CategorieRepository : ICategorieRepository
    {
        private const string categorieTable = "categories";
        private const string categorieInRecetteTable = "categories_recettes";

        readonly IDBSession _dbSession;
        public CategorieRepository(IDBSession dbSession)
        {
            _dbSession = dbSession;
        }

        #region Querries

        #region Querries GET

        private const string _queryGetAllCategories =
                   "SELECT " +
                   $"{categorieTable}.id, {categorieTable}.nom " +
                   $"FROM {categorieTable} ";

        private const string _queryGetCategoriesOfRecette =
            "SELECT " +
            $"{categorieTable}.id, {categorieTable}.nom " +
            $"FROM {categorieTable} " +
            $"JOIN {categorieInRecetteTable} ON {categorieTable}.id = {categorieInRecetteTable}.id_categorie " +
            $"WHERE {categorieInRecetteTable}.id_recette = @Id";

        private const string _queryGetCategorieRelationshipsById =
            "SELECT " +
            $"{categorieInRecetteTable}.id_recette " +
            $"FROM {categorieInRecetteTable} " +
            $"WHERE {categorieInRecetteTable}.id_categorie = @Id";

        #endregion

        #region Querries SET

        private const string _queryCreateCategorie =
            $"INSERT INTO {categorieTable} " +
            "(nom) " +
            "VALUES(@nom) " +
            "RETURNING id;";

        private const string _queryUpdateCategorie =
            $"UPDATE {categorieTable} " +
            "SET nom = @nom " +
            "WHERE id = @id";

        private const string _queryDeleteCategorie =
            $"DELETE FROM CATEGORIES C " +
            "WHERE C.id = @id " +
            "AND NOT EXISTS " +
            "(SELECT 1 " +
            "FROM CATEGORIES_RECETTES CR " +
            "WHERE CR.id_categorie = C.id)";

        private const string _queryAddCategorieToRecette =
            $"INSERT INTO {categorieInRecetteTable} " +
            "(id_recette, id_categorie) " +
            "VALUES(@id_recette, @id_categorie)";

        private const string _queryRemoveCategorieFromRecette =
            $"DELETE FROM {categorieInRecetteTable} " +
            "WHERE id_recette = @id_recette AND id_categorie = @id_categorie";

        #endregion

        #endregion

        #region Methods

        #region Getter

        public async Task<List<Categorie>> GetAllCategoriesAsync()
        {
            List<Categorie> categories;
            categories = (await _dbSession.Connection.QueryAsync<Categorie>(_queryGetAllCategories, transaction: _dbSession.Transaction)).ToList();
            return categories;
        }

        public async Task<List<Categorie>> GetCategoriesOfRecetteAsync(int id)
        {
            List<Categorie> categories;

            categories = (await _dbSession.Connection.QueryAsync<Categorie>(_queryGetCategoriesOfRecette, new
            {
                Id = id
            }, transaction: _dbSession.Transaction)).ToList();

            return categories;
        }

        public async Task<List<int>> GetCategorieRelationshipsByIdAsync(int id)
        {
            List<int> recetteIds;
            recetteIds = (await _dbSession.Connection.QueryAsync<int>(_queryGetCategorieRelationshipsById, new
            {
                Id = id
            }, transaction: _dbSession.Transaction)).ToList();

            return recetteIds;
        }

        #endregion

        #region Setter

        public async Task<int> CreateCategorieAsync(string nom)
        {
            int newId = await _dbSession.Connection.QuerySingleAsync<int>(_queryCreateCategorie, new
            {
                nom = nom
            }, transaction: _dbSession.Transaction);
            return newId;
        }

        public async Task<int> UpdateCategorieAsync(Categorie categorie)
        {
            int rowsAffected = await _dbSession.Connection.ExecuteAsync(_queryUpdateCategorie, new
            {
                nom = categorie.nom,
                id = categorie.id
            }, transaction: _dbSession.Transaction);
            return rowsAffected;
        }

        public async Task<int> DeleteCategorieAsync(int id)
        {
            int rowsAffected = await _dbSession.Connection.ExecuteAsync(_queryDeleteCategorie, new
            {
                id = id
            }, transaction: _dbSession.Transaction);
            return rowsAffected;
        }

        public async Task<int> AddCategorieToRecetteAsync(int id_recette, Categorie categorie)
        {
            int rowsAffected = await _dbSession.Connection.ExecuteAsync(_queryAddCategorieToRecette, new
            {
                id_recette = id_recette,
                id_categorie = categorie.id
            }, transaction: _dbSession.Transaction);
            return rowsAffected;
        }

        public async Task<int> RemoveCategorieFromRecetteAsync(int id_recette, Categorie categorie)
        {
            int rowsAffected = await _dbSession.Connection.ExecuteAsync(_queryRemoveCategorieFromRecette, new
            {
                id_recette = id_recette,
                id_categorie = categorie.id
            }, transaction: _dbSession.Transaction);
            return rowsAffected;
        }

        #endregion

        #endregion
    }
}
