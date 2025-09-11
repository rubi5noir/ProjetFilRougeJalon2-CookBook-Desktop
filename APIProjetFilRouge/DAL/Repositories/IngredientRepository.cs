using APIProjetFilRouge.DAL.Interfaces;
using APIProjetFilRouge.DAL.Session;
using APIProjetFilRouge.Models.BussinessObjects;
using Dapper;

namespace APIProjetFilRouge.DAL.Repositories
{
    public class IngredientRepository : IIngredientRepository
    {
        private const string ingredientTable = "ingredients";
        private const string ingredientInRecetteTable = "ingredients_recettes";

        readonly IDBSession _dbSession;
        public IngredientRepository(IDBSession dbSession)
        {
            _dbSession = dbSession;
        }

        #region Queries

        #region Queries GET

        private const string _queryGetAllIngredients =
            "SELECT " +
            "id, nom " +
            $"FROM {ingredientTable}";

        private const string _queryGetIngredientsWithQuantitiesOfRecette =
            "SELECT " +
            $"{ingredientTable}.id, {ingredientTable}.nom, {ingredientInRecetteTable}.quantite " +
            $"FROM {ingredientTable} " +
            $"JOIN {ingredientInRecetteTable} ON {ingredientTable}.id = {ingredientInRecetteTable}.id_ingredient " +
            $"WHERE {ingredientInRecetteTable}.id_recette = @Id";

        #endregion

        #region Queries SET

        private const string _queryCreateIngredient =
            $"INSERT INTO {ingredientTable} " +
            "(nom) " +
            "VALUES(@nom) " +
            "RETURNING id;";

        private const string _queryDeleteIngredient =
            $"DELETE FROM {ingredientTable} " +
            "WHERE id = @id";

        #endregion

        #endregion

        #region Methods

        #region Getter

        public async Task<List<Ingredient>> GetAllIngredientsAsync()
        {
            List<Ingredient> ingredients;

            ingredients = (await _dbSession.Connection.QueryAsync<Ingredient>(_queryGetAllIngredients)).ToList();

            return ingredients;
        }


        public async Task<List<Ingredient>> GetIngredientsWithQuantitiesOfRecetteAsync(int id)
        {
            List<Ingredient> ingredients;

            ingredients = (await _dbSession.Connection.QueryAsync<Ingredient>(_queryGetIngredientsWithQuantitiesOfRecette, new { Id = id })).ToList();

            return ingredients;
        }

        #endregion

        #region Setter

        public async Task<int> CreateIngredientAsync(Ingredient ingredient)
        {
            var id = await _dbSession.Connection.ExecuteScalarAsync<int>(_queryCreateIngredient, new
            {
                ingredient.nom
            });
            return id;
        }

        public async Task<int> DeleteIngredientAsync(int id)
        {
            int rowAffected = await _dbSession.Connection.ExecuteAsync(_queryDeleteIngredient, new { id });
            return rowAffected;
        }

        #endregion

        #endregion
    }
}
