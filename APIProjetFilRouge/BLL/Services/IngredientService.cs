using APIProjetFilRouge.BLL.Interfaces;
using APIProjetFilRouge.DAL.Interfaces;
using APIProjetFilRouge.Models.BussinessObjects;
using APIProjetFilRouge.Models.DataTransfertObjects.Between;
using System.Text;

namespace APIProjetFilRouge.BLL.Services
{
    public class IngredientService : IIngredientService
    {
        private readonly IIngredientRepository _ingredientRepository;

        public IngredientService(IIngredientRepository ingredientRepository)
        {
            _ingredientRepository = ingredientRepository;
        }

        /// <summary>
        /// Retrieves all ingredients with their quantities for a specific recipe by the ID of the recipe.
        /// </summary>
        /// <param name="id">ID of the recipe</param>
        /// <returns></returns>
        public async Task<List<Ingredient>> GetIngredientsWithQuantitiesOfRecette(int id)
        {
            var ingredients = await _ingredientRepository.GetIngredientsWithQuantitiesOfRecette(id);

            return ingredients;
        }
    }
}
