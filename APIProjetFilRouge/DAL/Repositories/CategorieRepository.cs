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

        #endregion

        #region Querries SET

        private const string _queryCreateCategorie =
            $"INSERT INTO {categorieTable} " +
            "(nom) " +
            "VALUES(@nom) " +
            "RETURNING id;";

        private const string _queryDeleteCategorie =
            $"DELETE FROM {categorieTable} " +
            "WHERE id = @id";

        #endregion

        #endregion

        #region Methods

        #region Getter

        public async Task<List<Categorie>> GetAllCategoriesAsync()
        {
            List<Categorie> categories;
            categories = (await _dbSession.Connection.QueryAsync<Categorie>(_queryGetAllCategories)).ToList();
            return categories;
        }

        public async Task<List<Categorie>> GetCategoriesOfRecetteAsync(int id)
        {
            List<Categorie> categories;

            categories = (await _dbSession.Connection.QueryAsync<Categorie>(_queryGetCategoriesOfRecette, new { Id = id })).ToList();

            return categories;
        }

        #endregion

        #region Setter

        public async Task<int> CreateCategorieAsync(string nom)
        {
            int newId = await _dbSession.Connection.QuerySingleAsync<int>(_queryCreateCategorie, new { nom = nom });
            return newId;
        }

        public async Task<int> DeleteCategorieAsync(int id)
        {
            int rowsAffected = await _dbSession.Connection.ExecuteAsync(_queryDeleteCategorie, new { id = id });
            return rowsAffected;
        }

        #endregion

        #endregion
    }
}
