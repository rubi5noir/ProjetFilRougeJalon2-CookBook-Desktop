using APIProjetFilRouge.BLL.Interfaces;
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

        public RecettesController(IRecetteService recetteService)
        {
            _recetteService = recetteService;
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
            try
            {
                return StatusCode(StatusCodes.Status200OK, await _recetteService.GetRecetteForVignette());
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ex.Message);
            }
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetRecetteById(int id)
        {
            return StatusCode(StatusCodes.Status200OK, await _recetteService.GetRecetteDetailsById(id));
        }

        #endregion
    }
}
