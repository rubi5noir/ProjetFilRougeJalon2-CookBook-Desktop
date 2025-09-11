using APIProjetFilRouge.BLL.Interfaces;
using APIProjetFilRouge.DAL.Interfaces;
using APIProjetFilRouge.DAL.Repositories;
using APIProjetFilRouge.Models.BussinessObjects;
using APIProjetFilRouge.Models.DataTransfertObjects.Between;
using APIProjetFilRouge.Models.DataTransfertObjects.Out;

namespace APIProjetFilRouge.BLL.Services
{
    public class RecetteService : IRecetteService
    {
        private readonly IRecetteRepository _recetteRepository;

        public RecetteService(IRecetteRepository recetteRepository)
        {
            _recetteRepository = recetteRepository;
        }

        #region Getter

        public async Task<List<Recette>> GetRecetteVignetteAsync()
        {
            List<Recette> recettes = await _recetteRepository.GetAllRecettesAsync();

            return recettes;
        }

        public async Task<Recette> GetRecetteByIdAsync(int id)
        {
            var recette = await _recetteRepository.GetRecetteByIdAsync(id);

            return recette;
        }

        #endregion

        #region Setter

        public async Task<int> CreateRecetteAsync(Recette recette)
        {
            int newRecetteId = await _recetteRepository.CreateRecetteAsync(recette);
            return newRecetteId;
        }

        public async Task<int> UpdateRecetteAsync(Recette recette)
        {
            int rowAffected = await _recetteRepository.UpdateRecetteAsync(recette);
            return rowAffected;
        }

        public async Task<int> DeleteRecetteAsync(int id)
        {
            int rowAffected = await _recetteRepository.DeleteRecetteAsync(id);
            return rowAffected;
        }

        #endregion
    }

}
