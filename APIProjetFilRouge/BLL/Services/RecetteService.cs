using APIProjetFilRouge.BLL.Interfaces;
using APIProjetFilRouge.DAL.Interfaces;
using APIProjetFilRouge.DAL.Repositories;
using APIProjetFilRouge.Models.BussinessObjects;
using APIProjetFilRouge.Models.DataTransfertObjects.Between;
using APIProjetFilRouge.Models.DataTransfertObjects.Out;

namespace APIProjetFilRouge.BLL.Services
{
    public class RecetteService : IRecetteService
    {
        private readonly IRecetteRepository _recetteRepository;

        public RecetteService(IRecetteRepository recetteRepository)
        {
            _recetteRepository = recetteRepository;
        }

        #region Getter

        /// <summary>
        /// Retrieves a list of recipes formatted for vignettes
        /// </summary>
        /// <returns>
        /// <para>A list of RecetteForVignetteDTO objects representing the recipes for vignettes</para>
        /// <para>Throws an exception if an error occurs while processing the request</para>
        /// </returns>
        public async Task<List<Recette>> GetRecetteVignette()
        {
            try
            {
                List<Recette> recettes = await _recetteRepository.GetAllRecettes();

                return recettes;
            }
            catch (Exception ex)
            {
                throw new Exception("Error", ex);
            }
        }


        /// <summary>
        /// Retrieves detailed information about a recipe by it's ID
        /// </summary>
        /// <param name="id">ID of the recipe</param>
        /// <returns></returns>
        public async Task<Recette> GetRecetteById(int id)
        {
            try
            {
                var recette = await _recetteRepository.GetRecetteById(id);

                return recette;
            }
            catch (Exception ex)
            {
                throw new Exception("Error", ex);
            }
        }

        #endregion
    }

}
