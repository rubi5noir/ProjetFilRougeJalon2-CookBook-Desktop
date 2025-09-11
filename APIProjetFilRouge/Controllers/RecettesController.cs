using APIProjetFilRouge.BLL.Interfaces;
using APIProjetFilRouge.BLL.Services;
using APIProjetFilRouge.DAL.Interfaces;
using APIProjetFilRouge.Models.BussinessObjects;
using APIProjetFilRouge.Models.DataTransfertObjects.Between;
using APIProjetFilRouge.Models.DataTransfertObjects.In;
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
            var recettes = await _recetteService.GetRecetteVignetteAsync();

            var avis = await _avisService.GetAvisOfAllRecettesAsync();
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
            var recette = await _recetteService.GetRecetteByIdAsync(id);

            var avis = await _avisService.GetAvisOfRecetteAsync(id);
            var avisDTO = avis.Select(avis => new AvisOfRecetteDTO
            {
                note = avis.note,
                commentaire = avis.commentaire,
                id_utilisateur = avis.id_utilisateur
            }).ToList();

            var utilisateur = await _compteService.GetCompteByIdAsync(recette.id_utilisateur);
            var createur = new CreateurOfRecetteDTO
            {
                id = utilisateur.id,
                identifiant = utilisateur.identifiant
            };

            var ingredients = await _ingredientService.GetIngredientsWithQuantitiesOfRecetteAsync(id);
            var ingredientsList = ingredients.Select(ingredient => new IngredientDTO
            {
                id = ingredient.id,
                nom = ingredient.nom,
                quantite = ingredient.quantite
            }).ToList();

            var categories = await _categorieService.GetCategoriesOfRecetteAsync(id);
            var categoriesDTO = categories.Select(c => new CategorieDTO
            {
                id = c.id,
                nom = c.nom
            }).ToList();

            var etapes = await _etapeService.GetEtapesOfRecetteAsync(id);
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

        #region Poster

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateRecette([FromBody] RecetteCreateDTO recetteCreateDTO)
        {


            Recette recette = new Recette
            {
                id_utilisateur = recetteCreateDTO.id_utilisateur,
                nom = recetteCreateDTO.nom,
                description = recetteCreateDTO.description,
                temps_preparation = recetteCreateDTO.temps_preparation,
                temps_cuisson = recetteCreateDTO.temps_cuisson,
                difficulte = recetteCreateDTO.difficulte,
                img = recetteCreateDTO.img
            };

            List<Ingredient> ingredients = recetteCreateDTO.ingredients.Select(i => new Ingredient
            {
                id = i.id,
                nom = i.nom,
                quantite = i.quantite
            }).ToList();

            List<Etape> etapes = recetteCreateDTO.etapes.Select(e => new Etape
            {
                numero = e.numero,
                texte = e.texte
            }).ToList();

            List<Categorie> categories = recetteCreateDTO.categories.Select(c => new Categorie
            {
                id = c.id,
                nom = c.nom
            }).ToList();

            // Transaction a venir (attente du cours)

            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateRecette([FromBody] RecetteUpdateDTO recetteUpdateDTO)
        {


            Recette recette = new Recette
            {
                id = recetteUpdateDTO.id,
                nom = recetteUpdateDTO.nom,
                description = recetteUpdateDTO.description,
                temps_preparation = recetteUpdateDTO.temps_preparation,
                temps_cuisson = recetteUpdateDTO.temps_cuisson,
                difficulte = recetteUpdateDTO.difficulte,
                img = recetteUpdateDTO.img
            };

            List<Ingredient> ingredients = recetteUpdateDTO.ingredients.Select(i => new Ingredient
            {
                id = i.id,
                nom = i.nom,
                quantite = i.quantite
            }).ToList();

            List<Etape> etapes = recetteUpdateDTO.etapes.Select(e => new Etape
            {
                numero = e.numero,
                texte = e.texte
            }).ToList();

            List<Categorie> categories = recetteUpdateDTO.categories.Select(c => new Categorie
            {
                id = c.id,
                nom = c.nom
            }).ToList();

            // Transaction a venir (attente du cours)

            return StatusCode(StatusCodes.Status200OK);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> DeleteRecette(int id)
        {

            // Transaction a venir (attente du cours)

            return StatusCode(StatusCodes.Status201Created);
        }

        #endregion
    }
}
