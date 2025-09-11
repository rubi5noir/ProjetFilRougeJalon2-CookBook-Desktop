using APIProjetFilRouge.BLL.Interfaces;
using APIProjetFilRouge.DAL.Interfaces;
using APIProjetFilRouge.Models.BussinessObjects;
using APIProjetFilRouge.Models.DataTransfertObjects.Between;

namespace APIProjetFilRouge.BLL.Services
{
    public class AvisService : IAvisService
    {
        private readonly IAvisRepository _avisRepository;

        public AvisService(IAvisRepository avisRepository)
        {
            _avisRepository = avisRepository;
        }

        public async Task<List<Avis>> GetAvisOfAllRecettesAsync()
        {
            //Recuperer toutes les notes
            List<Avis> avis = await _avisRepository.GetAllAvisAsync();

            return avis;
        }

        public async Task<List<Avis>> GetAvisOfRecetteAsync(int id)
        {
            List<Avis> avis = await _avisRepository.GetAvisByRecetteIdAsync(id);

            return avis;
        }

        public async Task<int> CreateAvisAsync(Avis avis)
        {
            int newAvisId = await _avisRepository.CreateAvisAsync(avis);
            return newAvisId;
        }

        public async Task<int> DeleteAvisAsync(int id_recette, int id_utilisateur)
        {
            int rowsAffected = await _avisRepository.DeleteAvisAsync(id_recette, id_utilisateur);
            return rowsAffected;
        }
    }
}
