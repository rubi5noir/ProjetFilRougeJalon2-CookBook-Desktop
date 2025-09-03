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
        private readonly IAvisService _avisService;
        private readonly ICompteService _compteService;
        private readonly IIngredientService _ingredientService;
        private readonly ICategorieService _categorieService;
        private readonly IEtapeService _etapeService;

        public RecetteService(IRecetteRepository recetteRepository, IAvisService avisService, ICompteService compteService, IIngredientService ingredientService, ICategorieService categorieService, IEtapeService etapeService)
        {
            _recetteRepository = recetteRepository;
            _avisService = avisService;
            _compteService = compteService;
            _ingredientService = ingredientService;
            _categorieService = categorieService;
            _etapeService = etapeService;
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


        /// <summary>
        /// Retrieves detailed information about a recipe by it's ID
        /// </summary>
        /// <param name="id">ID of the recipe</param>
        /// <returns></returns>
        public async Task<RecetteDetailsDTO> GetRecetteDetailsById(int id)
        {
            try
            {
                var recette = await _recetteRepository.GetRecetteById(id);
                var avis = await _avisService.GetAvisOfRecette(id);
                var createur = await _compteService.GetCreateurById(recette.id_utilisateur);
                var ingredients = await _ingredientService.GetIngredientsWithQuantitiesOfRecette(id);
                var categories = await _categorieService.GetCategoriesOfRecette(id);
                var etapes = await _etapeService.GetEtapesOfRecette(id);

                RecetteDetailsDTO recetteDetails = new RecetteDetailsDTO
                {
                    id = recette.id,
                    identifiantCreateur = createur.identifiant,
                    nom = recette.nom,
                    description = recette.description,
                    temps_preparation = recette.temps_preparation,
                    temps_cuisson = recette.temps_cuisson,
                    difficulte = recette.difficulte,
                    img = recette.img,
                    ingredients = ingredients,
                    categories = categories,
                    etapes = etapes,
                    avis = avis
                };

                return recetteDetails;
            }
            catch (Exception ex)
            {
                throw new Exception("Error", ex);
            }
        }

        #endregion
    }
}
