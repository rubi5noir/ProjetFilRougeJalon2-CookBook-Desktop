using APIProjetFilRouge.Models.DataTransfertObjects.Between;

namespace APIProjetFilRouge.BLL.Interfaces
{
    public interface ICategorieService
    {
        Task<List<CategorieDTO>> GetCategoriesOfRecette(int id);
    }
}
