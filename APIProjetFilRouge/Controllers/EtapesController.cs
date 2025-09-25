using APIProjetFilRouge.BLL.Interfaces;
using APIProjetFilRouge.Models.BussinessObjects;
using APIProjetFilRouge.Models.DataTransfertObjects.Between;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;

namespace APIProjetFilRouge.Controllers
{
    [Authorize(Roles = "Administrateur,Utilisateur")]
    [Route("api/[controller]")]
    [ApiController]
    public class EtapesController : ControllerBase
    {
        private readonly ICookBookService _recetteService;

        public EtapesController(ICookBookService recetteService)
        {
            _recetteService = recetteService;
        }

        #region GET

        [HttpGet()]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetAllEtapes()
        {
            List<Etape> etapes = await _recetteService.GetAllEtapesAsync();
            return (StatusCode(StatusCodes.Status200OK, etapes));
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetEtapesOfRecette(int id)
        {
            List<Etape> etapes = await _recetteService.GetEtapesOfRecetteAsync(id);

            List<EtapeDTO> etapesDTO = etapes.Select(e => new EtapeDTO
            {
                numero = e.numero,
                texte = e.texte
            }).ToList();

            return (StatusCode(StatusCodes.Status200OK, etapesDTO));
        }

        #endregion

        #region POST

        [Authorize(Roles = "Administrateur")]
        [HttpPost("{id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateEtape([FromRoute] int id, [FromBody] EtapeDTO etapeDTO)
        {
            var etape = new Etape
            {
                id_recette = id,
                numero = etapeDTO.numero,
                texte = etapeDTO.texte
            };

            var result = await _recetteService.CreateEtapeAsync(etape);
            return Ok(result);
        }

        #endregion

        #region PUT

        [Authorize(Roles = "Administrateur")]
        [HttpPut("{id}/{num}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateEtape([FromRoute] int id,[FromRoute] int num, [FromBody] EtapeDTO etapeDTO)
        {
            var etape = new Etape
            {
                id_recette = id,
                numero = etapeDTO.numero,
                texte = etapeDTO.texte
            };

            var result = await _recetteService.UpdateEtapeAsync(num, etape);
            return Ok(result);
        }

        #endregion

        #region DELETE

        [Authorize(Roles = "Administrateur")]
        [HttpDelete("{id}/{num}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> DeleteEtape([FromRoute] int id, [FromRoute] int num)
        {
            var result = await _recetteService.DeleteEtapeAsync(num, id);
            return Ok(result);
        }

        #endregion
    }
}
