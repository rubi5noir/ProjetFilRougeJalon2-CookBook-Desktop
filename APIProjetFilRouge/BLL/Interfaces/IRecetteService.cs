using APIProjetFilRouge.Models.BussinessObjects;
using APIProjetFilRouge.Models.DataTransfertObjects.Out;

namespace APIProjetFilRouge.BLL.Interfaces
{
    public interface IRecetteService
    {
        #region Avis

        Task<List<Avis>> GetAvisOfAllRecettesAsync();

        Task<List<Avis>> GetAvisOfRecetteAsync(int id);

        Task<int> CreateAvisAsync(Avis avis);

        Task<int> DeleteAvisAsync(int id_recette, int id_utilisateur);

        #endregion

        #region Categorie

        Task<List<Categorie>> GetAllCategoriesAsync();

        Task<List<Categorie>> GetCategoriesOfRecetteAsync(int id);

        Task<int> CreateCategorieAsync(string nom);

        Task<int> DeleteCategorieAsync(int id);

        #endregion

        #region Compte

        Task<List<Compte>> GetAllComptesAsync();

        Task<Compte> GetCompteByIdAsync(int id);

        Task<int> CreateCompteAsync(Compte compte);

        Task<int> DeleteCompteAsync(int id);

        #endregion

        #region Etape

        Task<List<Etape>> GetEtapesOfRecetteAsync(int id);

        Task<int> CreateEtapeAsync(Etape etape);

        Task<int> DeleteEtapeAsync(int id_recette, int numero);

        #endregion

        #region Ingredient

        Task<List<Ingredient>> GetAllIngredientsAsync();

        Task<List<Ingredient>> GetIngredientsWithQuantitiesOfRecetteAsync(int id);

        Task<int> CreateIngredientAsync(Ingredient ingredient);

        Task<int> DeleteIngredientAsync(int id);

        #endregion

        #region Recette

        /// <summary>
        /// Retrieves a list of recipes formatted for vignettes
        /// </summary>
        /// <returns>
        /// <para>A list of RecetteForVignetteDTO objects representing the recipes for vignettes</para>
        /// <para>Throws an exception if an error occurs while processing the request</para>
        /// </returns>
        Task<List<Recette>> GetRecetteVignetteAsync();

        /// <summary>
        /// Retrieves detailed information about a recipe by it's ID
        /// </summary>
        /// <param name="id">ID of the recipe</param>
        /// <returns></returns>
        Task<Recette> GetRecetteByIdAsync(int id);

        Task<int> CreateRecetteAsync(Recette recette);

        Task<int> UpdateRecetteAsync(Recette recette);

        Task<int> DeleteRecetteAsync(int id);

        #endregion
    }
}
