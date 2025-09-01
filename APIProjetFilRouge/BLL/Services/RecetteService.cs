using APIProjetFilRouge.BLL.Interfaces;
using APIProjetFilRouge.DAL.Interfaces;
using APIProjetFilRouge.DAL.Repositories;
using APIProjetFilRouge.Models.BussinessObjects;
using APIProjetFilRouge.Models.DataTransfertObjects.Out;

namespace APIProjetFilRouge.BLL.Services
{
    public class RecetteService : IRecetteService
    {
        private readonly IRecetteRepository _recetteRepository;
        private readonly IAvisService _avisService;

        public RecetteService(IRecetteRepository recetteRepository, IAvisService avisService)
        {
            _recetteRepository = recetteRepository;
            _avisService = avisService;
        }

        #region Getter

        /// <summary>
        /// Retrieves a list of recipes formatted for vignettes
        /// </summary>
        /// <returns>
        /// <para>A list of RecetteForVignetteDTO objects representing the recipes for vignettes</para>
        /// <para>Throws an exception if an error occurs while processing the request</para>
        /// </returns>
        public async Task<List<RecetteForVignetteDTO>> GetRecetteForVignette()
        {
            try
            {
                List<Recette> recettes = await _recetteRepository.GetAllRecettes();
                AverageNoteDTO averageNotes = await _avisService.GetAverageNoteOfAllRecettes();

                List<RecetteForVignetteDTO> recetteForVignetteList = recettes.Select(r => new RecetteForVignetteDTO
                {
                    id = r.id,
                    nom = r.nom,
                    description = r.description,
                    img = r.img,
                    noteMoyenne = averageNotes.averageNotesDictionary.TryGetValue(r.id, out var average) ? average : 0
                }).ToList();

                return recetteForVignetteList;
            }
            catch (Exception ex)
            {
                throw new Exception("Error", ex);
            }
        }

        #endregion
    }
}
