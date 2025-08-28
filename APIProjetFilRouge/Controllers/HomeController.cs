using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIProjetFilRouge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetForHomePage()
        {
            try
            {
                return StatusCode(StatusCodes.Status200OK, "API is running And this is the home page stuff getter");
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
