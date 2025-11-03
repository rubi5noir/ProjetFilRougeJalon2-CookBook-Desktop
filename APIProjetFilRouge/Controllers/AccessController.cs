using APIProjetFilRouge.BLL.Interfaces;
using APIProjetFilRouge.Models.DataTransfertObjects.In;
using APIProjetFilRouge.Models.DataTransfertObjects.Out;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace APIProjetFilRouge.Controllers
{
    /// <summary>
    /// Contrôleur pour l'authentification des utilisateurs et la génération de jetons JWT.
    /// </summary>
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class AccessController : ControllerBase
    {
        private readonly IAuthentificationService _jwtTokenService;

        /// <summary>
        /// Initialise une nouvelle instance du contrôleur <see cref="AuthenticationController"/>.
        /// </summary>
        /// <param name="jwtTokenService">Service pour la génération de jetons JWT.</param>
        public AccessController(IAuthentificationService jwtTokenService)
        {
            _jwtTokenService = jwtTokenService;
        }

        /// <summary>
        /// Authentifie un utilisateur et retourne un jeton JWT si les informations sont valides.
        /// </summary>
        /// <param name="validator">Validateur pour le modèle <see cref="LoginDTO"/>.</param>
        /// <param name="request">Données de connexion de l'utilisateur.</param>
        /// <returns>Un jeton JWT si l'authentification réussit, sinon un code 401.</returns>
        [HttpPost("Login")]
        [ProducesResponseType(typeof(JwtDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public IActionResult Login(IValidator<LoginDTO> validator, [FromBody] LoginDTO request)
        {
            validator.ValidateAndThrow(request);

            var token = _jwtTokenService.Authenticate(request.Username, request.Password);

            if (token != null)
            {
                return Ok(new JwtDTO { Token = token });
            }

            throw new UnauthorizedAccessException("Nom d'utilisateur ou mot de passe incorrect.");
        }
    }
}
