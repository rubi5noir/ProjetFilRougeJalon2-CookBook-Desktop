using APIProjetFilRouge.BLL.Interfaces;
using APIProjetFilRouge.Models.BussinessObjects;
using APIProjetFilRouge.Models.DataTransfertObjects.Between;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIProjetFilRouge.Controllers
{
    [Authorize(Roles = "Administrateur,Utilisateur")]
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICookBookService _recetteService;

        public CategoriesController(ICookBookService recetteService)
        {
            _recetteService = recetteService;
        }

        #region GET

        /// <summary>
        /// Retrieves all categories
        /// </summary>
        /// <returns></returns>
        [HttpGet]
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

        [HttpGet("RecettesIDs/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetRecipesIDsFromCategorieID([FromRoute] int id)
        {
            var recetteIDs = await _recetteService.GetCategorieRelationshipsByIdAsync(id);

            return StatusCode(StatusCodes.Status200OK, recetteIDs);
        }

        [HttpGet("{idRecette}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetCategorieByRecetteID([FromRoute] int idRecette)
        {
            var recetteIDs = await _recetteService.GetCategoriesOfRecetteAsync(idRecette);

            return StatusCode(StatusCodes.Status200OK, recetteIDs);
        }

        #endregion

        #region POST

        [Authorize(Roles = "Administrateur")]
        [HttpPost()]
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

            if (result == 0)
            {
                return BadRequest("Création de la catégorie échouée.");
            }
            return StatusCode(StatusCodes.Status201Created, result);
        }

        #endregion

        #region PUT

        [Authorize(Roles = "Administrateur")]
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateCategorie([FromRoute] int id, [FromBody] CategorieDTO categorieDTO)
        {
            var categorie = new Categorie
            {
                id = id,
                nom = categorieDTO.nom
            };

            bool result = await _recetteService.UpdateCategorieAsync(categorie);

            if (result == false)
            {
                return BadRequest("Mise à jour de la catégorie échouée.");
            }
            return Ok(result);
        }

        #endregion

        #region DELETE

        [Authorize(Roles = "Administrateur")]
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> DeleteCategorie([FromRoute] int id)
        {
            var result = await _recetteService.DeleteCategorieAsync(id);

            if (result == false)
            {
                return BadRequest("Suppression de la catégorie échouée.");
            }
            return Ok(result);
        }

        #endregion
    }
}
