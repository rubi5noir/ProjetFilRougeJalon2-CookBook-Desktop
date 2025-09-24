using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIProjetFilRouge.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetForHomePage()
        {
            return StatusCode(StatusCodes.Status200OK, "API is running And this is the home page stuff getter");
        }
    }
}
