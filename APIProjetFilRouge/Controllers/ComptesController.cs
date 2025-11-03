using APIProjetFilRouge.BLL.Interfaces;
using APIProjetFilRouge.Models.DataTransfertObjects.Out;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace APIProjetFilRouge.Controllers
{
    [Authorize(Policy = "UserOrAdmin")]
    [Route("api/[controller]")]
    [ApiController]
    public class ComptesController : ControllerBase
    {
        private readonly ICookBookService _recetteService;

        public ComptesController(ICookBookService recetteService)
        {
            _recetteService = recetteService;
        }

        #region GET

        /// <summary>
        /// Retrieve All user's accounts
        /// </summary>
        /// <returns></returns>
        [HttpGet()]
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

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetCompteDetails([FromRoute] int id)
        {
            var compte = await _recetteService.GetCompteByIdAsync(id);
            var compteDetailsDTO = new CompteDetailsDTO
            {
                id = compte.id,
                identifiant = compte.identifiant,
                nom = compte.nom,
                prenom = compte.prenom,
                email = compte.email,
                admin = compte.admin
            };

            return Ok(compteDetailsDTO);
        }

        #endregion

        #region POST



        #endregion

        #region PUT



        #endregion

        #region DELETE



        #endregion
    }
}
