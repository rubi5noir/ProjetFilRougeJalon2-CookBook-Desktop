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
    public class CookBookController : ControllerBase
    {
        private readonly IRecetteService _recetteService;

        public CookBookController(IRecetteService recetteService)
        {
            _recetteService = recetteService;
        }

        #region Getter

        #region Avis



        #endregion

        #region Categories

        /// <summary>
        /// Retrieves all categories
        /// </summary>
        /// <returns></returns>
        [HttpGet("Categories")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetAllCategories()
        {
            var categories = await _recetteService.GetAllCategoriesAsync();
            var categoriesDTO = categories.Select(c => new CategorieDTO
            {
                id = c.id,
                nom = c.nom
            }).ToList();

            return StatusCode(StatusCodes.Status200OK, categoriesDTO);
        }

        #endregion

        #region Comptes

        /// <summary>
        /// Retrieve All user's accounts
        /// </summary>
        /// <returns></returns>
        [HttpGet("Comptes")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetComptes()
        {
            var comptes = await _recetteService.GetAllComptesAsync();
            var comptesDTO = comptes.Select(c => new CompteDTO
            {
                id = c.id,
                identifiant = c.identifiant
            }).ToList();

            return Ok(comptesDTO);
        }

        #endregion

        #region Etapes



        #endregion

        #region Ingredients

        [HttpGet("Ingredients")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetIngredients()
        {
            var ingredients = await _recetteService.GetAllIngredientsAsync();
            var ingredientsDTO = ingredients.Select(i => new IngredientDTO
            {
                id = i.id,
                nom = i.nom
            }).ToList();

            return Ok(ingredientsDTO);
        }

        #endregion

        #region Recettes

        /// <summary>
        /// Retrieves a list of recipes formatted for vignettes
        /// </summary>
        /// <returns></returns>
        [HttpGet("Recettes")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetRecettesVignettes()
        {
            var recettes = await _recetteService.GetRecetteVignetteAsync();

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
        /// Retrieves detailed information about a specific recipe by its ID
        /// </summary>
        /// <returns></returns>
        [HttpGet("Recettes/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetRecetteById(int id)
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

        #endregion

        #region Poster

        #region Avis

        [HttpPost("Recettes/{id}/Avis/Create")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateAvisOnRecette(int id, [FromBody] AvisOfRecetteDTO avisOfRecetteDTO)
        {
            var avis = new Avis
            {
                id_recette = id,
                id_utilisateur = avisOfRecetteDTO.id_utilisateur,
                note = avisOfRecetteDTO.note,
                commentaire = avisOfRecetteDTO.commentaire
            };

            var result = await _recetteService.CreateAvisAsync(avis);
            return Ok(result);
        }

        [HttpPost("Recettes/{id}/Avis/Update")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateAvisOnRecette(int id, [FromBody] AvisOfRecetteDTO avisOfRecetteDTO)
        {
            var avis = new Avis
            {
                id_recette = id,
                id_utilisateur = avisOfRecetteDTO.id_utilisateur,
                note = avisOfRecetteDTO.note,
                commentaire = avisOfRecetteDTO.commentaire
            };

            var result = await _recetteService.UpdateAvisAsync(avis);
            return Ok(result);
        }

        [HttpPost("Recettes/{id}/Avis/Delete")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> DeleteAvisOnRecette(int id, [FromBody] AvisOfRecetteDTO avisOfRecetteDTO)
        {
            var avis = new Avis
            {
                id_recette = id,
                id_utilisateur = avisOfRecetteDTO.id_utilisateur,
                note = avisOfRecetteDTO.note,
                commentaire = avisOfRecetteDTO.commentaire
            };

            var result = await _recetteService.DeleteAvisAsync(avis.id_recette, avis.id_utilisateur);
            return Ok(result);
        }

        #endregion

        #region Categories

        [HttpPost("Categories/Create")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateCategorie([FromBody] CategorieDTO categorieDTO)
        {
            var categorie = new Categorie
            {
                id = 0,
                nom = categorieDTO.nom
            };

            var result = await _recetteService.CreateCategorieAsync(categorie);
            return Ok(result);
        }

        #endregion

        #region Comptes



        #endregion

        #region Etapes



        #endregion

        #region Ingredients

        /// <summary>
        /// Create a new ingredient
        /// </summary>
        /// <returns></returns>
        [HttpPost("Ingredients/Create")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateIngredient([FromBody] string nom)
        {
            var ingredient = new Ingredient
            {
                id = 0,
                nom = nom
            };

            var result = await _recetteService.CreateIngredientAsync(ingredient);

            return Ok(result);
        }

        #endregion

        #region Recette

        [HttpPost("Recettes/Create")]
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

        [HttpPost("Recettes/Update/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateRecette(int id, [FromBody] RecetteUpdateDTO recetteUpdateDTO)
        {


            Recette recette = new Recette
            {
                id = id,
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

        [HttpPost("Recettes/Delete/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> DeleteRecette(int id)
        {

            // Transaction a venir (attente du cours)

            return StatusCode(StatusCodes.Status201Created);
        }

        #endregion

        #endregion
    }
}
