using APIProjetFilRouge.BLL.Interfaces;
using APIProjetFilRouge.Models.BussinessObjects;
using APIProjetFilRouge.Models.DataTransfertObjects.Between;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace APIProjetFilRouge.Controllers
{
    [Authorize(Policy = "UserOrAdmin")]
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientsController : ControllerBase
    {
        private readonly ICookBookService _recetteService;

        public IngredientsController(ICookBookService recetteService)
        {
            _recetteService = recetteService;
        }

        #region GET

        [HttpGet]
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

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetRecettesIDsFromIngredient([FromRoute] int id)
        {
            var ids = await _recetteService.GetRecettesIDsFromIngredientAsync(id);

            return Ok(ids);
        }

        [HttpGet("recette/{idrecette}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetIngredientsOfRecette([FromRoute] int idrecette)
        {
            var ingredients = await _recetteService.GetIngredientsWithQuantitiesOfRecetteAsync(idrecette);
            var ingredientsDTO = ingredients.Select(i => new IngredientDTO
            {
                id = i.id,
                nom = i.nom,
                quantite = i.quantite
            }).ToList();

            return Ok(ingredientsDTO);
        }

        #endregion

        #region POST

        /// <summary>
        /// Create a new ingredient
        /// </summary>
        /// <returns></returns>
        [Authorize(Roles = "Admin")]
        [HttpPost("Create")]
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

        [Authorize(Roles = "Admin")]
        [HttpPost("AddToRecette/{id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> AddIngredientToRecette([FromRoute] int id, [FromBody] Ingredient ingredientDTO)
        {
            var ingredient = new Ingredient
            {
                id = ingredientDTO.id,
                nom = ingredientDTO.nom
            };

            var result = await _recetteService.AddIngredientToRecetteAsync(id, ingredient);
            return Ok(result);
        }

        #endregion

        #region PUT

        [Authorize(Roles = "Admin")]
        [HttpPut("Update/{id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateIngredient([FromRoute] int id, [FromBody] string nom)
        {
            var ingredient = new Ingredient
            {
                id = id,
                nom = nom
            };

            var result = await _recetteService.UpdateIngredientAsync(ingredient);
            return Ok(result);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("UpdateQuantityFromRecette/{id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> ModifyIngredientFromRecette([FromRoute] int id, [FromBody] IngredientDTO ingredientDTO)
        {
            var ingredient = new Ingredient
            {
                id = ingredientDTO.id,
                nom = ingredientDTO.nom
            };

            var isdel = await _recetteService.RemoveIngredientFromRecetteAsync(id, ingredient);
            if (isdel)
            {
                var result = await _recetteService.AddIngredientToRecetteAsync(id, ingredient);
                return Ok(result);
            }

            return BadRequest();
        }

        #endregion

        #region DELETE

        [Authorize(Roles = "Admin")]
        [HttpDelete("Delete/{id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> DeleteIngredient([FromRoute] int id)
        {
            var result = await _recetteService.DeleteIngredientAsync(id);
            return Ok(result);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("RemoveFromRecette/{id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> RemoveIngredientFromRecette([FromRoute] int id, [FromBody] IngredientDTO ingredientDTO)
        {
            var ingredient = new Ingredient
            {
                id = ingredientDTO.id,
                nom = ingredientDTO.nom
            };

            var result = await _recetteService.RemoveIngredientFromRecetteAsync(id, ingredient);
            return Ok(result);
        }

        #endregion
    }
}
