using APIProjetFilRouge.BLL.Interfaces;
using APIProjetFilRouge.BLL.Services;
using APIProjetFilRouge.DAL.Interfaces;
using APIProjetFilRouge.Models.BussinessObjects;
using APIProjetFilRouge.Models.DataTransfertObjects.Between;
using APIProjetFilRouge.Models.DataTransfertObjects.Out;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace APIProjetFilRouge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecettesController : ControllerBase
    {
        private readonly IRecetteService _recetteService;
        private readonly IAvisService _avisService;
        private readonly ICompteService _compteService;
        private readonly IIngredientService _ingredientService;
        private readonly ICategorieService _categorieService;
        private readonly IEtapeService _etapeService;

        public RecettesController(IRecetteService recetteService, IAvisService avisService, ICompteService compteService, IIngredientService ingredientService, ICategorieService categorieService, IEtapeService etapeService)
        {
            _recetteService = recetteService;
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
        /// <para>200 OK - Returns the list of recipes for vignettes</para>
        /// <para>400 Bad Request - If an error occurs while processing the request</para>
        /// </returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetRecettesVignettes()
        {
            var recettes = await _recetteService.GetRecetteVignette();

            var avis = await _avisService.GetAvisOfAllRecettes();
            AverageNoteDTO avisAverageNotes = new AverageNoteDTO();
            // Calcul des moyennes par recette
            avisAverageNotes.averageNotesDictionary = avis
                .GroupBy(a => a.id_recette)
                .ToDictionary(
                    g => g.Key,                   // idRecette
                    g => g.Average(a => a.note)   // moyenne des notes
                );

            List<RecetteForVignetteDTO> recetteForVignetteList = recettes.Select(r => new RecetteForVignetteDTO
            {
                id = r.id,
                nom = r.nom,
                description = r.description,
                img = r.img,
                noteMoyenne = avisAverageNotes.averageNotesDictionary.TryGetValue(r.id, out var average) ? average : 0
            }).ToList();

            return StatusCode(StatusCodes.Status200OK, recetteForVignetteList);
        }

        /// <summary>
        /// Retrieves detailed information about a specific recipe by its ID
        /// </summary>
        /// <param name="id">ID of the recipe</param>
        /// <returns></returns>
        [HttpGet("id")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetRecetteById(int id)
        {
            var recette = await _recetteService.GetRecetteById(id);

            var avis = await _avisService.GetAvisOfRecette(id);
            var avisDTO = avis.Select(avis => new AvisOfRecetteDTO
            {
                note = avis.note,
                commentaire = avis.commentaire,
                id_utilisateur = avis.id_utilisateur
            }).ToList();

            var utilisateur = await _compteService.GetCreateurById(recette.id_utilisateur);
            var createur = new CreateurOfRecetteDTO
            {
                id = utilisateur.id,
                identifiant = utilisateur.identifiant
            };

            var ingredients = await _ingredientService.GetIngredientsWithQuantitiesOfRecette(id);
            var ingredientsList = ingredients.Select(ingredient => new IngredientDTO
            {
                id = ingredient.id,
                nom = ingredient.nom,
                quantite = ingredient.quantite
            }).ToList();

            var categories = await _categorieService.GetCategoriesOfRecette(id);
            var categoriesDTO = categories.Select(c => new CategorieDTO
            {
                id = c.id,
                nom = c.nom
            }).ToList();

            var etapes = await _etapeService.GetEtapesOfRecette(id);
            List<EtapeDTO> etapesDTO = etapes.Select(e => new EtapeDTO
            {
                numero = e.numero,
                texte = e.texte
            }).ToList();

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
                ingredients = ingredientsList,
                categories = categoriesDTO,
                etapes = etapesDTO,
                avis = avisDTO
            };

            return StatusCode(StatusCodes.Status200OK, recetteDetails);

        }

        #endregion
    }
}
