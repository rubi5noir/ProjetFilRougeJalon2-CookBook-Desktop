using APIProjetFilRouge.Models.BussinessObjects;
using APIProjetFilRouge.Models.DataTransfertObjects.Out;

namespace APIProjetFilRouge.BLL.Interfaces
{
    public interface IRecetteService
    {
        #region Avis

        /// <summary>
        /// Retrieves all reviews from the database
        /// </summary>
        /// <returns><see cref="List{Avis}"/> of <see cref="Avis"/> : All reviews</returns>
        Task<List<Avis>> GetAvisOfAllRecettesAsync();

        /// <summary>
        /// Retrieves reviews for a specific recipe based on recipe ID
        /// </summary>
        /// <returns><see cref="List{Avis}"/> of <see cref="Avis"/> : All reviews of the recipe</returns>
        Task<List<Avis>> GetAvisOfRecetteAsync(int id);

        /// <summary>
        /// Create a new review for a recipe
        /// </summary>
        /// <returns></returns>
        Task<int> CreateAvisAsync(Avis avis);

        /// <summary>
        /// Delete a review based on recipe ID and user ID
        /// </summary>
        /// <returns></returns>
        Task<int> DeleteAvisAsync(int id_recette, int id_utilisateur);

        #endregion

        #region Categorie

        /// <summary>
        /// Retrieves all categories from the database
        /// </summary>
        /// <returns><see cref="List{Categorie}"/> of <see cref="Categorie"/> : All Categories</returns>
        Task<List<Categorie>> GetAllCategoriesAsync();

        /// <summary>
        /// Retrieves categories associated with a specific recipe based on recipe ID
        /// </summary>
        /// <returns><see cref="List{Categorie}"/> of <see cref="Categorie"/> : All categories of the recipe</returns>
        Task<List<Categorie>> GetCategoriesOfRecetteAsync(int id);

        /// <summary>
        /// Create a new category in the database
        /// </summary>
        /// <returns><see cref="int"/> : Id of the new categorie</returns>
        Task<int> CreateCategorieAsync(string nom);

        /// <summary>
        /// Delete a category from the database
        /// </summary>
        /// <returns></returns>
        Task<int> DeleteCategorieAsync(int id);

        #endregion

        #region Compte

        /// <summary>
        /// Retrieves all user accounts from the database
        /// </summary>
        /// <returns><see cref="List{Compte}"/> of <see cref="Compte"/> : All user's accounts</returns>
        Task<List<Compte>> GetAllComptesAsync();

        /// <summary>
        /// Retrieves a user account by its ID
        /// </summary>
        /// <returns><see cref="Compte"/> : The user account</returns>
        Task<Compte> GetCompteByIdAsync(int id);

        /// <summary>
        /// Create a new user account in the database
        /// </summary>
        /// <returns><see cref="int"/> : Id of the new user account</returns>
        Task<int> CreateCompteAsync(Compte compte);

        /// <summary>
        /// Delete a user account from the database
        /// </summary>
        /// <returns></returns>
        Task<int> DeleteCompteAsync(int id);

        #endregion

        #region Etape

        /// <summary>
        /// Retrieves all steps for a specific recipe based on recipe ID
        /// </summary>
        /// <returns><see cref="List{Etape}"/> of <see cref="Etape"/> : All steps of the recipe</returns>
        Task<List<Etape>> GetEtapesOfRecetteAsync(int id);

        /// <summary>
        /// Create a new step for a recipe
        /// </summary>
        /// <returns><see cref="int"/> : Number of the new step</returns>
        Task<int> CreateEtapeAsync(Etape etape);

        /// <summary>
        /// Delete a step from a recipe based on recipe ID and step number
        /// </summary>
        /// <returns></returns>
        Task<int> DeleteEtapeAsync(int id_recette, int numero);

        #endregion

        #region Ingredient

        /// <summary>
        /// Retrieves all ingredients from the database
        /// </summary>
        /// <returns><see cref="List{Ingredient}"/> of <see cref="Ingredient"/> : All ingredients</returns>
        Task<List<Ingredient>> GetAllIngredientsAsync();

        /// <summary>
        /// Retrieves ingredients with their quantities for a specific recipe
        /// </summary>
        /// <returns><see cref="List{Ingredient}"/> of <see cref="Ingredient"/> : All ingredients of the recipe with their quantities</returns>
        Task<List<Ingredient>> GetIngredientsWithQuantitiesOfRecetteAsync(int id);

        /// <summary>
        /// Create a new ingredient in the database
        /// </summary>
        /// <returns><see cref="int"/> : Id of the new ingredient</returns>
        Task<int> CreateIngredientAsync(Ingredient ingredient);

        /// <summary>
        /// Delete an ingredient from the database
        /// </summary>
        /// <returns></returns>
        Task<int> DeleteIngredientAsync(int id);

        #endregion

        #region Recette

        /// <summary>
        /// Retrieves a list of recipes formatted for vignettes
        /// </summary>
        /// <returns><see cref="List{Recette}"/> of <see cref="Recette"/> : Recipes for vignettes uses</returns>
        Task<List<Recette>> GetRecetteVignetteAsync();

        /// <summary>
        /// Retrieves detailed information about a recipe by it's ID
        /// </summary>
        /// <returns><see cref="Recette"/> : The recipe</returns>
        Task<Recette> GetRecetteByIdAsync(int id);

        /// <summary>
        /// Create a new recipe to the database
        /// </summary>
        /// <returns><see cref="int"/> : Id of the new recipe</returns>
        Task<int> CreateRecetteAsync(Recette recette);

        /// <summary>
        /// Update an existing recipe in the database
        /// </summary>
        /// <returns></returns>
        Task<int> UpdateRecetteAsync(Recette recette);

        /// <summary>
        /// Delete a recipe from the database
        /// </summary>
        /// <returns></returns>
        Task<int> DeleteRecetteAsync(int id);

        #endregion
    }
}
