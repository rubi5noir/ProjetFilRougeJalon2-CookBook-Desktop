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

        public async Task<List<EtapeDTO>> GetEtapesOfRecette(int id)
        {
            try
            {
                List<Etape> etapes = await _etapeRepository.GetEtapesOfRecette(id);

                List<EtapeDTO> etapesDTO = etapes.Select(e => new EtapeDTO
                {
                    numero = e.numero,
                    texte = e.texte
                }).ToList();

                return etapesDTO;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving steps for the recipe.", ex);
            }
        }
    }
}
