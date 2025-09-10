using APIProjetFilRouge.DAL.Interfaces;
using APIProjetFilRouge.DAL.Session;
using APIProjetFilRouge.Models.BussinessObjects;
using Dapper;

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

        #region Queries

        private const string _queryGetCategoriesOfRecette =
            "SELECT " +
            $"{categorieTable}.id, {categorieTable}.nom " +
            $"FROM {categorieTable} " +
            $"JOIN {categorieInRecetteTable} ON {categorieTable}.id = {categorieInRecetteTable}.id_categorie " +
            $"WHERE {categorieInRecetteTable}.id_recette = @Id";

        #endregion

        #region Getter

        public async Task<List<Categorie>> GetCategoriesOfRecetteAsync(int id)
        {
            List<Categorie> categories;

            categories = (await _dbSession.Connection.QueryAsync<Categorie>(_queryGetCategoriesOfRecette, new { Id = id })).ToList();

            return categories;
        }

        #endregion
    }
}
