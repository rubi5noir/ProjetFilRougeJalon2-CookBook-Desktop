using APIProjetFilRouge.BLL.Interfaces;
using APIProjetFilRouge.DAL.Interfaces;
using APIProjetFilRouge.Models.BussinessObjects;
using APIProjetFilRouge.Models.DataTransfertObjects.Between;

namespace APIProjetFilRouge.BLL.Services
{
    public class CompteService : ICompteService
    {
        private readonly ICompteRepository _compteRepository;

        public CompteService(ICompteRepository compteRepository)
        {
            _compteRepository = compteRepository;
        }

        public async Task<List<Compte>> GetAllComptesAsync()
        {
            var compte = await _compteRepository.GetAllComptesAsync();
            return compte;
        }

        public async Task<Compte> GetCompteByIdAsync(int id)
        {
            var createur = await _compteRepository.GetCompteByIdAsync(id);

            return createur;
        }

        public async Task<int> CreateCompteAsync(Compte compte)
        {
            int newCompteId = await _compteRepository.CreateCompteAsync(compte);
            return newCompteId;
        }

        public async Task<int> DeleteCompteAsync(int id)
        {
            int rowsAffected = await _compteRepository.DeleteCompteAsync(id);
            return rowsAffected;
        }
    }
}
