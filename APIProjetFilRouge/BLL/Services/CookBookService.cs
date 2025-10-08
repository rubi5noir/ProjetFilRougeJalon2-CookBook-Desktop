using APIProjetFilRouge.BLL.Interfaces;
using APIProjetFilRouge.DAL.Interfaces;
using APIProjetFilRouge.DAL.Repositories;
using APIProjetFilRouge.DAL.UnitsOfWork;
using APIProjetFilRouge.Models.BussinessObjects;
using APIProjetFilRouge.Models.DataTransfertObjects.Between;
using APIProjetFilRouge.Models.DataTransfertObjects.Out;

namespace APIProjetFilRouge.BLL.Services
{
    public class CookBookService : ICookBookService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CookBookService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        #region Avis

        #region GET

        public async Task<List<Avis>> GetAvisOfAllRecettesAsync()
        {
            //Recuperer toutes les notes
            List<Avis> avis = await _unitOfWork.Avis.GetAllAvisAsync();

            return avis;
        }

        public async Task<List<Avis>> GetAvisOfRecetteAsync(int id)
        {
            List<Avis> avis = await _unitOfWork.Avis.GetAvisByRecetteIdAsync(id);

            return avis;
        }

        #endregion

        #region SET

        public async Task<int> CreateAvisAsync(Avis avis)
        {
            _unitOfWork.BeginTransaction();

            int newAvisId = await _unitOfWork.Avis.CreateAvisAsync(avis);

            if (newAvisId > 1)
            {
                _unitOfWork.Rollback();
                return 0; // number of line updated = 0
            }

            _unitOfWork.Commit();
            return newAvisId;
        }

        public async Task<bool> UpdateAvisAsync(Avis avis)
        {
            int rowsAffected = await _unitOfWork.Avis.UpdateAvisAsync(avis);

            bool isUpdated = rowsAffected == 1;
            return isUpdated;
        }

        public async Task<bool> DeleteAvisAsync(int id_recette, int id_utilisateur)
        {
            int rowsAffected = await _unitOfWork.Avis.DeleteAvisAsync(id_recette, id_utilisateur);

            bool isDeleted = rowsAffected == 1;
            return isDeleted;
        }

        #endregion

        #endregion

        #region Categorie

        #region GET

        public async Task<List<Categorie>> GetAllCategoriesAsync()
        {
            var categories = await _unitOfWork.Categorie.GetAllCategoriesAsync();
            return categories;
        }

        public async Task<List<Categorie>> GetCategoriesOfRecetteAsync(int id)
        {
            var categories = await _unitOfWork.Categorie.GetCategoriesOfRecetteAsync(id);

            return categories;
        }

        public async Task<List<int>> GetCategorieRelationshipsByIdAsync(int id)
        {
            var categorieRelationships = await _unitOfWork.Categorie.GetCategorieRelationshipsByIdAsync(id);
            return categorieRelationships;
        }

        #endregion

        #region SET

        public async Task<int> CreateCategorieAsync(Categorie categorie)
        {
            int newCategorieId = await _unitOfWork.Categorie.CreateCategorieAsync(categorie.nom);
            return newCategorieId;
        }

        public async Task<bool> UpdateCategorieAsync(Categorie categorie)
        {
            int rowsAffected = await _unitOfWork.Categorie.UpdateCategorieAsync(categorie);

            bool isUpdated = rowsAffected == 1;
            return isUpdated;
        }

        public async Task<bool> DeleteCategorieAsync(int id)
        {
            int rowsAffected = await _unitOfWork.Categorie.DeleteCategorieAsync(id);

            bool isDeleted = rowsAffected == 1;
            return isDeleted;
        }

        public async Task<bool> AddCategorieToRecetteAsync(int id_recette, Categorie categorie)
        {
            int rowsAffected = await _unitOfWork.Categorie.AddCategorieToRecetteAsync(id_recette, categorie);

            bool isAdded = rowsAffected == 1;
            return isAdded;
        }

        public async Task<bool> RemoveCategorieFromRecetteAsync(int id_recette, Categorie categorie)
        {
            int rowsAffected = await _unitOfWork.Categorie.RemoveCategorieFromRecetteAsync(id_recette, categorie);

            bool isRemoved = rowsAffected == 1;
            return isRemoved;
        }

        #endregion

        #endregion

        #region Compte

        #region GET

        public async Task<List<Compte>> GetAllComptesAsync()
        {
            var compte = await _unitOfWork.Compte.GetAllComptesAsync();
            return compte;
        }

        public async Task<Compte> GetCompteByIdAsync(int id)
        {
            var createur = await _unitOfWork.Compte.GetCompteByIdAsync(id);

            return createur;
        }

        #endregion

        #region SET

        public async Task<int> CreateCompteAsync(Compte compte)
        {
            int newCompteId = await _unitOfWork.Compte.CreateCompteAsync(compte);
            return newCompteId;
        }

        public async Task<bool> UpdateCompteAsync(Compte compte)
        {
            int rowsAffected = await _unitOfWork.Compte.UpdateCompteAsync(compte);

            bool isUpdated = rowsAffected == 1;
            return isUpdated;
        }

        public async Task<bool> DeleteCompteAsync(int id)
        {
            int rowsAffected = await _unitOfWork.Compte.DeleteCompteAsync(id);

            bool isDeleted = rowsAffected == 1;
            return isDeleted;
        }

        #endregion

        #endregion

        #region Etape

        #region GET

        public async Task<List<Etape>> GetAllEtapesAsync()
        {
            List<Etape> etapes = await _unitOfWork.Etape.GetAllEtapesAsync();
            return etapes;
        }

        public async Task<List<Etape>> GetEtapesOfRecetteAsync(int id)
        {
            List<Etape> etapes = await _unitOfWork.Etape.GetEtapesOfRecetteAsync(id);

            return etapes;
        }

        #endregion

        #region SET

        public async Task<int> CreateEtapeAsync(Etape etape)
        {
            int rowsAffected = await _unitOfWork.Etape.CreateEtapeAsync(etape);
            return rowsAffected;
        }

        public async Task<bool> UpdateEtapeAsync(int num, Etape etape)
        {
            _unitOfWork.BeginTransaction();

            int rowsAffected = await _unitOfWork.Etape.UpdateEtapeAsync(num, etape);

            bool isUpdated = rowsAffected == 1;
            if (isUpdated)
            {
                _unitOfWork.Commit();
            }
            else
            {
                _unitOfWork.Rollback();
            }
            return isUpdated;
        }

        public async Task<bool> DeleteEtapeAsync(int num, int id)
        {
            int rowsAffected = await _unitOfWork.Etape.DeleteEtapeAsync(id, num);

            bool isDeleted = rowsAffected == 1;
            return isDeleted;
        }

        #endregion

        #endregion

        #region Ingredient

        #region GET

        public async Task<List<Ingredient>> GetAllIngredientsAsync()
        {
            var ingredients = await _unitOfWork.Ingredient.GetAllIngredientsAsync();
            return ingredients;
        }

        public async Task<List<Ingredient>> GetIngredientsWithQuantitiesOfRecetteAsync(int id)
        {
            var ingredients = await _unitOfWork.Ingredient.GetIngredientsWithQuantitiesOfRecetteAsync(id);

            return ingredients;
        }

        public async Task<List<int>> GetRecettesIDsFromIngredientAsync(int id)
        {
            var result = await _unitOfWork.Ingredient.GetRecettesIDsFromIngredientAsync(id);
            
            return result;
        }

        #endregion

        #region SET

        public async Task<int> CreateIngredientAsync(Ingredient ingredient)
        {
            int newIngredientId = await _unitOfWork.Ingredient.CreateIngredientAsync(ingredient);
            return newIngredientId;
        }

        public async Task<bool> UpdateIngredientAsync(Ingredient ingredient)
        {
            int rowsAffected = await _unitOfWork.Ingredient.UpdateIngredientAsync(ingredient);

            bool isUpdated = rowsAffected == 1;
            return isUpdated;
        }

        public async Task<bool> DeleteIngredientAsync(int id)
        {
            int rowsAffected = await _unitOfWork.Ingredient.DeleteIngredientAsync(id);

            bool isDeleted = rowsAffected == 1;
            return isDeleted;
        }

        public async Task<bool> AddIngredientToRecetteAsync(int id_recette, Ingredient ingredient)
        {
            int rowsAffected = await _unitOfWork.Ingredient.AddIngredientToRecetteAsync(id_recette, ingredient);

            bool isAdded = rowsAffected == 1;
            return isAdded;
        }

        public async Task<bool> RemoveIngredientFromRecetteAsync(int id_recette, Ingredient ingredient)
        {
            int rowsAffected = await _unitOfWork.Ingredient.RemoveIngredientFromRecetteAsync(id_recette, ingredient);

            bool isRemoved = rowsAffected == 1;
            return isRemoved;
        }

        #endregion

        #endregion

        #region Recette

        #region GET

        public async Task<List<Recette>> GetAllRecettesAsync()
        {
            List<Recette> recettes = await _unitOfWork.Recette.GetAllRecettesAsync();

            return recettes;
        }

        public async Task<Recette> GetRecetteByIdAsync(int id)
        {
            var recette = await _unitOfWork.Recette.GetRecetteByIdAsync(id);

            return recette;
        }

        #endregion

        #region SET

        public async Task<int> CreateRecetteAsync(Recette recette, List<Categorie> categories, List<Etape> etapes, List<Ingredient> ingredients)
        {
            _unitOfWork.BeginTransaction();

            try
            {
                int newRecetteId = await _unitOfWork.Recette.CreateRecetteAsync(recette);

                foreach (var categorie in categories)
                {
                    await _unitOfWork.Categorie.AddCategorieToRecetteAsync(newRecetteId, categorie);
                }

                foreach (var etape in etapes)
                {
                    etape.id_recette = newRecetteId;
                    await _unitOfWork.Etape.CreateEtapeAsync(etape);
                }

                foreach (var ingredient in ingredients)
                {
                    await _unitOfWork.Ingredient.AddIngredientToRecetteAsync(newRecetteId, ingredient);
                }

                _unitOfWork.Commit();
                return newRecetteId;
            }
            catch (Exception)
            {
                _unitOfWork.Rollback();
                throw;
            }
        }

        public async Task<bool> UpdateRecetteAsync(Recette recette, List<Categorie> categories, List<Etape> etapes, List<Ingredient> ingredients)
        {
            _unitOfWork.BeginTransaction();

            try
            {
                foreach (var categorie in categories)
                {
                    await _unitOfWork.Categorie.RemoveCategorieFromRecetteAsync(recette.id, categorie);
                    await _unitOfWork.Categorie.AddCategorieToRecetteAsync(recette.id, categorie);
                }

                foreach (var etape in etapes)
                {
                    etape.id_recette = recette.id;

                    await _unitOfWork.Etape.UpdateEtapeAsync(0, etape);
                }

                foreach (var ingredient in ingredients)
                {
                    await _unitOfWork.Ingredient.RemoveIngredientFromRecetteAsync(recette.id, ingredient);
                    await _unitOfWork.Ingredient.AddIngredientToRecetteAsync(recette.id, ingredient);
                }

                int rowAffected = await _unitOfWork.Recette.UpdateRecetteAsync(recette);

                bool isUpdated = rowAffected == 1;

                _unitOfWork.Commit();
                return isUpdated;
            }
            catch (Exception)
            {
                _unitOfWork.Rollback();
                throw;
            }
        }

        public async Task<bool> DeleteRecetteAsync(int id)
        {
            _unitOfWork.BeginTransaction();

            List<Categorie> categories = await _unitOfWork.Categorie.GetCategoriesOfRecetteAsync(id);
            List<Etape> etapes = await _unitOfWork.Etape.GetEtapesOfRecetteAsync(id);
            List<Ingredient> ingredients = await _unitOfWork.Ingredient.GetIngredientsWithQuantitiesOfRecetteAsync(id);

            foreach (var categorie in categories)
            {
                await _unitOfWork.Categorie.RemoveCategorieFromRecetteAsync(id, categorie);
            }

            foreach (var etape in etapes)
            {
                etape.id_recette = id;

                await _unitOfWork.Etape.DeleteEtapeAsync(etape.id_recette, etape.numero);
            }

            foreach (var ingredient in ingredients)
            {
                await _unitOfWork.Ingredient.RemoveIngredientFromRecetteAsync(id, ingredient);
            }

            int rowAffected = await _unitOfWork.Recette.DeleteRecetteAsync(id);

            bool isDeleted = rowAffected == 1;

            if (isDeleted)
            {
                _unitOfWork.Commit();
                return isDeleted;
            }
            _unitOfWork.Rollback();
            return isDeleted;
        }
    }

    #endregion

    #endregion

}
