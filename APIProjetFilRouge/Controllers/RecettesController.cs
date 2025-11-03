using APIProjetFilRouge.BLL.Interfaces;
using APIProjetFilRouge.Models.BussinessObjects;
using APIProjetFilRouge.Models.DataTransfertObjects.Between;
using APIProjetFilRouge.Models.DataTransfertObjects.In;
using APIProjetFilRouge.Models.DataTransfertObjects.Out;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace APIProjetFilRouge.Controllers
{
    [Authorize(Roles = "Admin")]
    [Authorize(Roles = "User")]
    [Route("api/[controller]")]
    [ApiController]
    public class RecettesController : ControllerBase
    {
        private readonly ICookBookService _recetteService;

        public RecettesController(ICookBookService recetteService)
        {
            _recetteService = recetteService;
        }

        #region GET

        /// <summary>
        /// Retrieves a list of recipes formatted for vignettes
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetRecettesVignettes()
        {
            var recettes = await _recetteService.GetAllRecettesAsync();

            var avis = await _recetteService.GetAvisOfAllRecettesAsync();
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
        /// Retrieves all recipes
        /// </summary>
        /// <returns></returns>
        [HttpGet("Details")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetAllRecettes()
        {
            var recettes = await _recetteService.GetAllRecettesAsync();

            List<RecetteDTO> recettesDTO = recettes.Select(r => new RecetteDTO
            {
                id = r.id,
                nom = r.nom,
                description = r.description,
                temps_preparation = r.temps_preparation,
                temps_cuisson = r.temps_cuisson,
                difficulte = r.difficulte,
                img = r.img,
            }).ToList();

            return StatusCode(StatusCodes.Status200OK, recettesDTO);
        }

        /// <summary>
        /// Retrieves detailed information about a specific recipe by its ID
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetRecetteById([FromRoute] int id)
        {
            var recette = await _recetteService.GetRecetteByIdAsync(id);

            var avis = await _recetteService.GetAvisOfRecetteAsync(id);
            var avisDTO = avis.Select(avis => new AvisOfRecetteDTO
            {
                note = avis.note,
                commentaire = avis.commentaire,
                id_utilisateur = avis.id_utilisateur
            }).ToList();

            var utilisateur = await _recetteService.GetCompteByIdAsync(recette.id_utilisateur);
            var createur = new CreateurOfRecetteDTO
            {
                id = utilisateur.id,
                identifiant = utilisateur.identifiant
            };

            var ingredients = await _recetteService.GetIngredientsWithQuantitiesOfRecetteAsync(id);
            var ingredientsList = ingredients.Select(ingredient => new IngredientDTO
            {
                id = ingredient.id,
                nom = ingredient.nom,
                quantite = ingredient.quantite
            }).ToList();

            var categories = await _recetteService.GetCategoriesOfRecetteAsync(id);
            var categoriesDTO = categories.Select(c => new CategorieDTO
            {
                id = c.id,
                nom = c.nom
            }).ToList();

            var etapes = await _recetteService.GetEtapesOfRecetteAsync(id);
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

        #region POST

        [Authorize(Roles = "Admin")]
        [HttpPost("Create")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateRecette([FromBody] RecetteCreateDTO recetteCreateDTO)
        {
            Recette recette = new Recette
            {
                id_utilisateur = recetteCreateDTO.id_utilisateur,
                nom = recetteCreateDTO.nom,
                description = recetteCreateDTO.description,
                temps_preparation = new TimeSpan(recetteCreateDTO.temps_preparation_heures, recetteCreateDTO.temps_preparation_minutes, 0),
                temps_cuisson = new TimeSpan(recetteCreateDTO.temps_cuisson_heures, recetteCreateDTO.temps_cuisson_minutes, 0),
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

            int newRecetteId = await _recetteService.CreateRecetteAsync(recette, categories, etapes, ingredients);

            return StatusCode(StatusCodes.Status201Created, newRecetteId);
        }

        #endregion

        #region PUT

        [Authorize(Roles = "Admin")]
        [HttpPut("Update/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateRecette([FromRoute] int id, [FromBody] RecetteUpdateDTO recetteUpdateDTO)
        {


            Recette recette = new Recette
            {
                id = id,
                nom = recetteUpdateDTO.nom,
                description = recetteUpdateDTO.description,
                temps_preparation = new TimeSpan(recetteUpdateDTO.temps_preparation_heures, recetteUpdateDTO.temps_preparation_minutes, 0),
                temps_cuisson = new TimeSpan(recetteUpdateDTO.temps_cuisson_heures, recetteUpdateDTO.temps_cuisson_minutes, 0),
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

            bool isUpdated = await _recetteService.UpdateRecetteAsync(recette, categories, etapes, ingredients);

            return StatusCode(StatusCodes.Status200OK, isUpdated);
        }

        #endregion

        #region DELETE

        [Authorize(Roles = "Admin")]
        [HttpDelete("Delete/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> DeleteRecette([FromRoute] int id)
        {
            bool isDeleted = await _recetteService.DeleteRecetteAsync(id);

            if (!isDeleted)
            {
                return BadRequest("Suppression de la recette échouée.");
            }
            return StatusCode(StatusCodes.Status204NoContent);
        }

        #endregion
    }
}
