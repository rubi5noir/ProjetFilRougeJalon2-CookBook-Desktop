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

        public async Task<Compte> GetCreateurByIdAsync(int Createur)
        {
            var createur = await _compteRepository.GetCompteByIdAsync(Createur);

            return createur;
        }
    }
}
