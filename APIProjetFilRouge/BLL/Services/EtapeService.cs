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
    }
}
