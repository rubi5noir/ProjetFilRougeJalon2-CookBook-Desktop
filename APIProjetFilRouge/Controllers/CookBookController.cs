﻿using APIProjetFilRouge.BLL.Interfaces;
using APIProjetFilRouge.BLL.Services;
using APIProjetFilRouge.DAL.Interfaces;
using APIProjetFilRouge.Models.BussinessObjects;
using APIProjetFilRouge.Models.DataTransfertObjects.Between;
using APIProjetFilRouge.Models.DataTransfertObjects.In;
using APIProjetFilRouge.Models.DataTransfertObjects.Out;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace APIProjetFilRouge.Controllers
{
    [Authorize(Roles = "Administrateur,Utilisateur")]
    [Route("api/[controller]")]
    [ApiController]
    public class CookBookController : ControllerBase
    {
        private readonly ICookBookService _recetteService;

        public CookBookController(ICookBookService recetteService)
        {
            _recetteService = recetteService;
        }

        #region Getter

        #region Avis



        #endregion

       

        #region Etapes



        #endregion

        

        #endregion

        #region Poster

        #region Avis

        [HttpPost("Recettes/{id}/Avis/Create")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateAvisOnRecette([FromRoute] int id, [FromBody] AvisOfRecetteDTO avisOfRecetteDTO)
        {
            var avis = new Avis
            {
                id_recette = id,
                id_utilisateur = avisOfRecetteDTO.id_utilisateur,
                note = avisOfRecetteDTO.note,
                commentaire = avisOfRecetteDTO.commentaire
            };

            var result = await _recetteService.CreateAvisAsync(avis);
            return Ok(result);
        }

        [HttpPost("Recettes/{id}/Avis/Update")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateAvisOnRecette([FromRoute] int id, [FromBody] AvisOfRecetteDTO avisOfRecetteDTO)
        {
            var avis = new Avis
            {
                id_recette = id,
                id_utilisateur = avisOfRecetteDTO.id_utilisateur,
                note = avisOfRecetteDTO.note,
                commentaire = avisOfRecetteDTO.commentaire
            };

            var result = await _recetteService.UpdateAvisAsync(avis);
            return Ok(result);
        }

        [HttpPost("Recettes/{id}/Avis/Delete")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> DeleteAvisOnRecette([FromRoute] int id, [FromBody] AvisOfRecetteDTO avisOfRecetteDTO)
        {
            var avis = new Avis
            {
                id_recette = id,
                id_utilisateur = avisOfRecetteDTO.id_utilisateur,
                note = avisOfRecetteDTO.note,
                commentaire = avisOfRecetteDTO.commentaire
            };

            var result = await _recetteService.DeleteAvisAsync(avis.id_recette, avis.id_utilisateur);
            return Ok(result);
        }

        #endregion


       



        #endregion
    }
}
