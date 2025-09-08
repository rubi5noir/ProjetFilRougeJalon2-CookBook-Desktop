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


        /// <summary>
        /// Retrieves the steps of a specific recipe by the ID of the recipe.
        /// </summary>
        /// <param name="id">ID of the recipe</param>
        /// <returns></returns>
        public async Task<List<Etape>> GetEtapesOfRecette(int id)
        {
            List<Etape> etapes = await _etapeRepository.GetEtapesOfRecette(id);

            return etapes;
        }
    }
}
