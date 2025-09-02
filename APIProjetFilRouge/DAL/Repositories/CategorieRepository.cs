using APIProjetFilRouge.DAL.Interfaces;
using APIProjetFilRouge.Models.BussinessObjects;
using Dapper;

namespace APIProjetFilRouge.DAL.Repositories
{
    public class CategorieRepository : ICategorieRepository
    {
        private readonly string _connectionString;
        private const string categorieTable = "categories";
        private const string categorieInRecetteTable = "categories_recettes";

        public CategorieRepository(IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            if (string.IsNullOrEmpty(connectionString))
            {
                throw new ArgumentNullException("Connection string 'DefaultConnection' not found.");
            }

            _connectionString = connectionString;
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

        public async Task<List<Categorie>> GetCategoriesOfRecette(int id)
        {
            try
            {
                List<Categorie> categories;

                using (var connexion = new Npgsql.NpgsqlConnection(_connectionString))
                {
                    categories = (await connexion.QueryAsync<Categorie>(_queryGetCategoriesOfRecette, new { Id = id })).ToList();
                }
                return categories;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving categories for the recipe.", ex);
            }
        }

        #endregion
    }
}
