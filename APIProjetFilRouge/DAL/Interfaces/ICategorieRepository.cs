using APIProjetFilRouge.Models.BussinessObjects;
using APIProjetFilRouge.Models.DataTransfertObjects.Between;

namespace APIProjetFilRouge.DAL.Interfaces
{
    public interface ICategorieRepository
    {
        Task<List<Categorie>> GetCategoriesOfRecette(int id);
    }
}
