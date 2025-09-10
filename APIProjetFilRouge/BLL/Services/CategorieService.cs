using APIProjetFilRouge.BLL.Interfaces;
using APIProjetFilRouge.DAL.Interfaces;
using APIProjetFilRouge.Models.BussinessObjects;
using APIProjetFilRouge.Models.DataTransfertObjects.Between;

namespace APIProjetFilRouge.BLL.Services
{
    public class CategorieService : ICategorieService
    {
        private readonly ICategorieRepository _categorieRepository;

        public CategorieService(ICategorieRepository categorieRepository)
        {
            _categorieRepository = categorieRepository;
        }


        public async Task<List<Categorie>> GetCategoriesOfRecetteAsync(int id)
        {
            var categories = await _categorieRepository.GetCategoriesOfRecetteAsync(id);

            return categories;
        }
    }
}
