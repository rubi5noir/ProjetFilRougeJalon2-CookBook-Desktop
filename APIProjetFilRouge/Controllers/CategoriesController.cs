using APIProjetFilRouge.BLL.Interfaces;
using APIProjetFilRouge.Models.BussinessObjects;
using APIProjetFilRouge.Models.DataTransfertObjects.Between;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace APIProjetFilRouge.Controllers
{
    [Authorize(Policy = "UserOrAdmin")]
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

            if (categoriesDTO.IsNullOrEmpty())
            {
                return BadRequest(categoriesDTO);
            }

            return StatusCode(StatusCodes.Status200OK, categoriesDTO);
        }

        [HttpGet("RecettesIDs/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetRecipesIDsFromCategorieID([FromRoute] int id)
        {
            var recetteIDs = await _recetteService.GetCategorieRelationshipsByIdAsync(id);

            if (recetteIDs.IsNullOrEmpty())
            {
                return BadRequest("Aucune Recettes trouvées");
            }

            return StatusCode(StatusCodes.Status200OK, recetteIDs);
        }

        [HttpGet("{idRecette}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetCategoriesByRecetteID([FromRoute] int idRecette)
        {
            var categories = await _recetteService.GetCategoriesOfRecetteAsync(idRecette);

            if (categories.IsNullOrEmpty())
            {
                return BadRequest(categories);
            }

            return StatusCode(StatusCodes.Status200OK, categories);
        }

        #endregion

        #region POST

        [Authorize(Roles = "Admin")]
        [HttpPost()]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateCategorie(IValidator<CategorieDTO> validator, [FromBody] CategorieDTO categorieDTO)
        {
            if (validator.Validate(categorieDTO).IsValid)
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
            else
            {
                return BadRequest("Création de la catégorie échouée.");
            }
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("AddToRecette/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> AddCategorieToRecette(IValidator<CategorieDTO> validator, [FromRoute] int id, [FromBody] CategorieDTO categorieDTO)
        {
            if (validator.Validate(categorieDTO).IsValid)
            {
                var categorie = new Categorie
                {
                    id = categorieDTO.id,
                    nom = categorieDTO.nom
                };

                var result = await _recetteService.AddCategorieToRecetteAsync(id, categorie);
                if (!result)
                {
                    return BadRequest("Ajout de la catégorie à la recette échouée.");
                }
                return Ok(result);
            }
            return BadRequest("Ajout de la catégorie à la recette échouée.");
        }

        #endregion

        #region PUT

        [Authorize(Roles = "Admin")]
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateCategorie(IValidator<CategorieDTO> validator, [FromRoute] int id, [FromBody] CategorieDTO categorieDTO)
        {
            if (validator.Validate(categorieDTO).IsValid)
            {
                var categorie = new Categorie
                {
                    id = id,
                    nom = categorieDTO.nom
                };

                bool result = await _recetteService.UpdateCategorieAsync(categorie);

                if (!result)
                {
                    return BadRequest("Mise à jour de la catégorie échouée.");
                }
                return Ok(result);
            }
            return BadRequest("Mise à jour de la catégorie échouée.");
        }

        #endregion

        #region DELETE

        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> DeleteCategorie([FromRoute] int id)
        {
            var result = await _recetteService.DeleteCategorieAsync(id);

            if (!result)
            {
                return BadRequest("Suppression de la catégorie échouée.");
            }
            return Ok(result);
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("RemoveFromRecette/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> RemoveCategorieFromRecette(IValidator<CategorieDTO> validator, [FromRoute] int id, [FromBody] CategorieDTO categorieDTO)
        {
            if (validator.Validate(categorieDTO).IsValid)
            {
                var categorie = new Categorie
                {
                    id = categorieDTO.id,
                    nom = categorieDTO.nom
                };
                var result = await _recetteService.RemoveCategorieFromRecetteAsync(id, categorie);
                if (!result)
                {
                    return BadRequest("Suppression de la catégorie à la recette échouée.");
                }
                return Ok(result);
            }
            return BadRequest("Suppression de la catégorie à la recette échouée.");
        }

        #endregion

    }
}
