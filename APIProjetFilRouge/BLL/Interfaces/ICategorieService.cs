using APIProjetFilRouge.Models.BussinessObjects;
using APIProjetFilRouge.Models.DataTransfertObjects.Between;

namespace APIProjetFilRouge.BLL.Interfaces
{
    public interface ICategorieService
    {
        Task<List<Categorie>> GetCategoriesOfRecette(int id);
    }
}
