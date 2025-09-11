using APIProjetFilRouge.BLL.Interfaces;
using APIProjetFilRouge.DAL.Interfaces;
using APIProjetFilRouge.Models.BussinessObjects;
using APIProjetFilRouge.Models.DataTransfertObjects.Between;

namespace APIProjetFilRouge.BLL.Services
{
    public class EtapeService : IEtapeService
    {
        private readonly IEtapeRepository _etapeRepository;

        public EtapeService(IEtapeRepository etapeRepository)
        {
            _etapeRepository = etapeRepository;
        }


        public async Task<List<Etape>> GetEtapesOfRecetteAsync(int id)
        {
            List<Etape> etapes = await _etapeRepository.GetEtapesOfRecetteAsync(id);

            return etapes;
        }

        public async Task<int> CreateEtapeAsync(Etape etape)
        {
            int rowsAffected = await _etapeRepository.CreateEtapeAsync(etape);
            return rowsAffected;
        }

        public async Task<int> DeleteEtapeAsync(int id_recette, int numero)
        {
            int rowsAffected = await _etapeRepository.DeleteEtapeAsync(id_recette, numero);
            return rowsAffected;
        }
    }
}
