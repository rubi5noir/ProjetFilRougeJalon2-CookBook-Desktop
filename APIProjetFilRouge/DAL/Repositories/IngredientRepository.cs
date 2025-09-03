using APIProjetFilRouge.DAL.Interfaces;
using APIProjetFilRouge.Models.BussinessObjects;
using Dapper;

namespace APIProjetFilRouge.DAL.Repositories
{
    public class IngredientRepository : IIngredientRepository
    {
        private readonly string _connectionString;
        private const string ingredientTable = "ingredients";
        private const string ingredientInRecetteTable = "ingredients_recettes";

        public IngredientRepository(IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            if (string.IsNullOrEmpty(connectionString))
            {
                throw new ArgumentNullException("Connection string 'DefaultConnection' not found.");
            }

            _connectionString = connectionString;
        }

        #region Queries

        private const string _queryGetIngredientsWithQuantitiesOfRecette =
            "SELECT " +
            $"{ingredientTable}.id, {ingredientTable}.nom, {ingredientInRecetteTable}.quantite " +
            $"FROM {ingredientTable} " +
            $"JOIN {ingredientInRecetteTable} ON {ingredientTable}.id = {ingredientInRecetteTable}.id_ingredient " +
            $"WHERE {ingredientInRecetteTable}.id_recette = @Id";

        #endregion

        #region Getter

        /// <summary>
        /// Retrieves the list of ingredients along with their quantities for a specific recipe by the ID of the recipe.
        /// </summary>
        /// <param name="id">ID of the recipe</param>
        /// <returns></returns>
        public async Task<List<Ingredient>> GetIngredientsWithQuantitiesOfRecette(int id)
        {
            try
            {
                List<Ingredient> ingredients;

                using (var connexion = new Npgsql.NpgsqlConnection(_connectionString))
                {
                    ingredients = (await connexion.QueryAsync<Ingredient>(_queryGetIngredientsWithQuantitiesOfRecette, new { Id = id })).ToList();
                }

                return ingredients;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving ingredients with quantities for the recipe.", ex);
            }
        }

        #endregion
    }
}
