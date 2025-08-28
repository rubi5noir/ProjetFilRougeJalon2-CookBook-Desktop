using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIProjetFilRouge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecettesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetRecettes()
        {
            try
            {
                return StatusCode(StatusCodes.Status200OK);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet("id")]
        public IActionResult GetRecetteById(int id)
        {
            return Ok();
        }
    }
}
