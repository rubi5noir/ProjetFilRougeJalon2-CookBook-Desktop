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

        private const string _queryGetRecettesIDsFromIngredient =
            "SELECT " +
            $"{ingredientInRecetteTable}.id_recette " +
            $"FROM {ingredientInRecetteTable} " +
            $"WHERE {ingredientInRecetteTable}.id_ingredient = @Id";

        #endregion

        #region Queries SET

        private const string _queryCreateIngredient =
            $"INSERT INTO {ingredientTable} " +
            "(nom) " +
            "VALUES(@nom) " +
            "RETURNING id";

        private const string _queryUpdateIngredient =
            $"UPDATE {ingredientTable} " +
            "SET nom = @nom " +
            "WHERE id = @id";

        private const string _queryDeleteIngredient =
            $"DELETE FROM {ingredientTable} " +
            "WHERE id = @id";

        private const string _queryAddIngredientToRecette =
            $"INSERT INTO {ingredientInRecetteTable} " +
            "(id_recette, id_ingredient, quantite) " +
            "VALUES(@id_recette, @id_ingredient, @quantite)";

        private const string _queryRemoveIngredientFromRecette =
            $"DELETE FROM {ingredientInRecetteTable} " +
            "WHERE id_recette = @id_recette AND id_ingredient = @id_ingredient";

        #endregion

        #endregion

        #region Methods

        #region Getter

        public async Task<List<Ingredient>> GetAllIngredientsAsync()
        {
            List<Ingredient> ingredients;

            ingredients = (await _dbSession.Connection.QueryAsync<Ingredient>(_queryGetAllIngredients, transaction: _dbSession.Transaction)).ToList();

            return ingredients;
        }

        public async Task<List<Ingredient>> GetIngredientsWithQuantitiesOfRecetteAsync(int id)
        {
            List<Ingredient> ingredients;

            ingredients = (await _dbSession.Connection.QueryAsync<Ingredient>(_queryGetIngredientsWithQuantitiesOfRecette, new
            {
                Id = id
            }, transaction: _dbSession.Transaction)).ToList();

            return ingredients;
        }

        public async Task<List<int>> GetRecettesIDsFromIngredientAsync(int id)
        {
            List<int> ids;

            ids = (await _dbSession.Connection.QueryAsync<int>(_queryGetRecettesIDsFromIngredient, new
            {
                Id = id
            }, transaction: _dbSession.Transaction)).ToList();

            return ids;
        }

        #endregion

        #region Setter

        public async Task<int> CreateIngredientAsync(Ingredient ingredient)
        {
            var id = await _dbSession.Connection.ExecuteScalarAsync<int>(_queryCreateIngredient, new
            {
                ingredient.nom
            }, transaction: _dbSession.Transaction);
            return id;
        }

        public async Task<int> UpdateIngredientAsync(Ingredient ingredient)
        {
            var rowsAffected = await _dbSession.Connection.ExecuteAsync(_queryUpdateIngredient, new
            {
                nom = ingredient.nom,
                id = ingredient.id
            }, transaction: _dbSession.Transaction);
            return rowsAffected;
        }

        public async Task<int> DeleteIngredientAsync(int id)
        {
            int rowsAffected = await _dbSession.Connection.ExecuteAsync(_queryDeleteIngredient, new
            {
                id = id
            }, transaction: _dbSession.Transaction);
            return rowsAffected;
        }

        public async Task<int> AddIngredientToRecetteAsync(int id_recette, Ingredient ingredient)
        {
            var rowsAffected = await _dbSession.Connection.ExecuteAsync(_queryAddIngredientToRecette, new
            {
                id_recette = id_recette,
                id_ingredient = ingredient.id,
                quantite = ingredient.quantite
            }, transaction: _dbSession.Transaction);
            return rowsAffected;
        }

        public async Task<int> RemoveIngredientFromRecetteAsync(int id_recette, Ingredient ingredient)
        {
            var rowsAffected = await _dbSession.Connection.ExecuteAsync(_queryRemoveIngredientFromRecette, new
            {
                id_recette = id_recette,
                id_ingredient = ingredient.id
            }, transaction: _dbSession.Transaction);
            return rowsAffected;
        }

        #endregion

        #endregion
    }
}
