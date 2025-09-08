using APIProjetFilRouge.Models.BussinessObjects;
using APIProjetFilRouge.Models.DataTransfertObjects.Between;

namespace APIProjetFilRouge.BLL.Interfaces
{
    public interface IIngredientService
    {
        Task<List<Ingredient>> GetIngredientsWithQuantitiesOfRecette(int id);
    }
}
