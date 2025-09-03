using APIProjetFilRouge.BLL.Interfaces;
using APIProjetFilRouge.DAL.Interfaces;
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


        /// <summary>
        /// Retrieves all categories associated with a specific recipe by the ID of the recipe.
        /// </summary>
        /// <param name="id">ID of the recipe</param>
        /// <returns></returns>
        public async Task<List<CategorieDTO>> GetCategoriesOfRecette(int id)
        {
            try
            {
                var categories = await _categorieRepository.GetCategoriesOfRecette(id);

                return categories.Select(c => new CategorieDTO
                {
                    id = c.id,
                    nom = c.nom
                }).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving all categories.", ex);
            }
        }
    }
}
