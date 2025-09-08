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

        /// <summary>
        /// Retrieves the average note for all recipes.
        /// </summary>
        /// <returns>
        /// <para>An AverageNoteDTO object containing a dictionary with recipe IDs as keys and their corresponding average notes as values.</para>
        /// <para>Throws an exception if an error occurs while processing the request.</para>
        /// </returns>
        public async Task<List<Avis>> GetAvisOfAllRecettes()
        {
            try
            {
                //Recuperer toutes les notes
                List<Avis> avis = await _avisRepository.GetAllAvis();

                return avis;
            }
            catch (Exception ex)
            {
                throw new Exception("Error", ex);
            }
        }

        /// <summary>
        /// Retrieves all reviews of a specific recipe by its ID.
        /// </summary>
        /// <param name="id">ID of the recipe</param>
        /// <returns></returns>
        public async Task<List<Avis>> GetAvisOfRecette(int id)
        {
            try
            {
                List<Avis> avis = await _avisRepository.GetAvisByRecetteId(id);

                return avis;
            }
            catch (Exception ex)
            {
                throw new Exception("Error", ex);
            }
        }
    }
}
