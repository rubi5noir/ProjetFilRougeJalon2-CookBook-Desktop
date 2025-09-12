using APIProjetFilRouge.BLL.Interfaces;
using APIProjetFilRouge.DAL.Interfaces;
using APIProjetFilRouge.DAL.Repositories;
using APIProjetFilRouge.Models.BussinessObjects;
using APIProjetFilRouge.Models.DataTransfertObjects.Between;
using APIProjetFilRouge.Models.DataTransfertObjects.Out;

namespace APIProjetFilRouge.BLL.Services
{
    public class RecetteService : IRecetteService
    {
        private readonly IAvisRepository _avisRepository;
        private readonly ICategorieRepository _categorieRepository;
        private readonly ICompteRepository _compteRepository;
        private readonly IEtapeRepository _etapeRepository;
        private readonly IIngredientRepository _ingredientRepository;
        private readonly IRecetteRepository _recetteRepository;

        public RecetteService(IAvisRepository avisRepository, ICategorieRepository categorieRepository, ICompteRepository compteRepository, IEtapeRepository etapeRepository, IIngredientRepository ingredientRepository, IRecetteRepository recetteRepository)
        { 
            _avisRepository = avisRepository;
            _categorieRepository = categorieRepository;
            _compteRepository = compteRepository;
            _etapeRepository = etapeRepository;
            _ingredientRepository = ingredientRepository;
            _recetteRepository = recetteRepository;
        }

        #region Avis

        public async Task<List<Avis>> GetAvisOfAllRecettesAsync()
        {
            //Recuperer toutes les notes
            List<Avis> avis = await _avisRepository.GetAllAvisAsync();

            return avis;
        }

        public async Task<List<Avis>> GetAvisOfRecetteAsync(int id)
        {
            List<Avis> avis = await _avisRepository.GetAvisByRecetteIdAsync(id);

            return avis;
        }

        public async Task<int> CreateAvisAsync(Avis avis)
        {
            int newAvisId = await _avisRepository.CreateAvisAsync(avis);
            return newAvisId;
        }

        public async Task<int> DeleteAvisAsync(int id_recette, int id_utilisateur)
        {
            int rowsAffected = await _avisRepository.DeleteAvisAsync(id_recette, id_utilisateur);
            return rowsAffected;
        }

        #endregion

        #region Categorie

        public async Task<List<Categorie>> GetAllCategoriesAsync()
        {
            var categories = await _categorieRepository.GetAllCategoriesAsync();
            return categories;
        }

        public async Task<List<Categorie>> GetCategoriesOfRecetteAsync(int id)
        {
            var categories = await _categorieRepository.GetCategoriesOfRecetteAsync(id);

            return categories;
        }

        public async Task<int> CreateCategorieAsync(string nom)
        {
            int newCategorieId = await _categorieRepository.CreateCategorieAsync(nom);
            return newCategorieId;
        }

        public async Task<int> DeleteCategorieAsync(int id)
        {
            int rowsAffected = await _categorieRepository.DeleteCategorieAsync(id);
            return rowsAffected;
        }

        #endregion

        #region Compte

        public async Task<List<Compte>> GetAllComptesAsync()
        {
            var compte = await _compteRepository.GetAllComptesAsync();
            return compte;
        }

        public async Task<Compte> GetCompteByIdAsync(int id)
        {
            var createur = await _compteRepository.GetCompteByIdAsync(id);

            return createur;
        }

        public async Task<int> CreateCompteAsync(Compte compte)
        {
            int newCompteId = await _compteRepository.CreateCompteAsync(compte);
            return newCompteId;
        }

        public async Task<int> DeleteCompteAsync(int id)
        {
            int rowsAffected = await _compteRepository.DeleteCompteAsync(id);
            return rowsAffected;
        }

        #endregion

        #region Etape

        public async Task<List<Etape>> GetEtapesOfRecetteAsync(int id)
        {
            List<Etape> etapes = await _etapeRepository.GetEtapesOfRecetteAsync(id);

            return etapes;
        }

        public async Task<int> CreateEtapeAsync(Etape etape)
        {
            int rowsAffected = await _etapeRepository.CreateEtapeAsync(etape);
            return rowsAffected;
        }

        public async Task<int> DeleteEtapeAsync(int id_recette, int numero)
        {
            int rowsAffected = await _etapeRepository.DeleteEtapeAsync(id_recette, numero);
            return rowsAffected;
        }

        #endregion

        #region Ingredient

        public async Task<List<Ingredient>> GetAllIngredientsAsync()
        {
            var ingredients = await _ingredientRepository.GetAllIngredientsAsync();
            return ingredients;
        }

        public async Task<List<Ingredient>> GetIngredientsWithQuantitiesOfRecetteAsync(int id)
        {
            var ingredients = await _ingredientRepository.GetIngredientsWithQuantitiesOfRecetteAsync(id);

            return ingredients;
        }

        public async Task<int> CreateIngredientAsync(Ingredient ingredient)
        {
            int newIngredientId = await _ingredientRepository.CreateIngredientAsync(ingredient);
            return newIngredientId;
        }

        public async Task<int> DeleteIngredientAsync(int id)
        {
            int rowsAffected = await _ingredientRepository.DeleteIngredientAsync(id);
            return rowsAffected;
        }

        #endregion

        #region Recette

        #region Getter

        public async Task<List<Recette>> GetRecetteVignetteAsync()
        {
            List<Recette> recettes = await _recetteRepository.GetAllRecettesAsync();

            return recettes;
        }

        public async Task<Recette> GetRecetteByIdAsync(int id)
        {
            var recette = await _recetteRepository.GetRecetteByIdAsync(id);

            return recette;
        }

        #endregion

        #region Setter

        public async Task<int> CreateRecetteAsync(Recette recette)
        {
            int newRecetteId = await _recetteRepository.CreateRecetteAsync(recette);
            return newRecetteId;
        }

        public async Task<int> UpdateRecetteAsync(Recette recette)
        {
            int rowAffected = await _recetteRepository.UpdateRecetteAsync(recette);
            return rowAffected;
        }

        public async Task<int> DeleteRecetteAsync(int id)
        {
            int rowAffected = await _recetteRepository.DeleteRecetteAsync(id);
            return rowAffected;
        }

        #endregion

        #endregion

    }

}
