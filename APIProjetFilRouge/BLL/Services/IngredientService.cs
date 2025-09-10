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

        public async Task<List<Ingredient>> GetIngredientsWithQuantitiesOfRecetteAsync(int id)
        {
            var ingredients = await _ingredientRepository.GetIngredientsWithQuantitiesOfRecetteAsync(id);

            return ingredients;
        }
    }
}
