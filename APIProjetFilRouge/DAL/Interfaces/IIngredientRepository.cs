using APIProjetFilRouge.Models.BussinessObjects;
using APIProjetFilRouge.Models.DataTransfertObjects.Between;

namespace APIProjetFilRouge.DAL.Interfaces
{
    public interface IIngredientRepository
    {
        Task<List<Ingredient>> GetIngredientsWithQuantitiesOfRecette(int id);
    }
}
