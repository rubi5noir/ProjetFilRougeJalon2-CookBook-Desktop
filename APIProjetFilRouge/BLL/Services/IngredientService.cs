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


        public async Task<List<IngredientDTO>> GetIngredientsWithQuantitiesOfRecette(int id)
        {
            try
            {
                var ingredients = await _ingredientRepository.GetIngredientsWithQuantitiesOfRecette(id);

                List<IngredientDTO> ingredientsList = ingredients.Select(ingredient => new IngredientDTO{
                    id = ingredient.id, 
                    nom = ingredient.nom,
                    quantite = ingredient.quantite
                }).ToList();

                return ingredientsList;
            }
            catch (Exception ex)
            {
                throw new Exception("Error", ex);
            }
        }
    }
}
