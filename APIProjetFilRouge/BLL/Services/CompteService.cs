using APIProjetFilRouge.BLL.Interfaces;
using APIProjetFilRouge.DAL.Interfaces;
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

        /// <summary>
        /// Retrieves the creator information by their ID.
        /// </summary>
        /// <param name="Createur">ID of the creator of the recipe</param>
        /// <returns></returns>
        public async Task<CreateurOfRecetteDTO> GetCreateurById(int Createur)
        {
            try
            {
                var createur = await _compteRepository.GetCompteById(Createur);
                return new CreateurOfRecetteDTO
                {
                    id = createur.id,
                    identifiant = createur.identifiant,
                };
            }
            catch (Exception ex)
            {
                throw new Exception("Error", ex);
            }
        }
    }
}
