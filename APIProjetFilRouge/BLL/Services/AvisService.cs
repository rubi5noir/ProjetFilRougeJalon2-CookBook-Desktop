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
        public async Task<AverageNoteDTO> GetAverageNoteOfAllRecettes()
        {
            try
            {
                //Recuperer toutes les notes
                List<Avis> avis = await _avisRepository.GetAllAvis();

                AverageNoteDTO avisAverageNotes = new AverageNoteDTO();

                // Calcul des moyennes par recette
                avisAverageNotes.averageNotesDictionary = avis
                    .GroupBy(a => a.id_recette)
                    .ToDictionary(
                        g => g.Key,                   // idRecette
                        g => g.Average(a => a.note)   // moyenne des notes
                    );

                return avisAverageNotes;
            }
            catch (Exception ex)
            {
                throw new Exception("Error", ex);
            }
        }

        public async Task<List<AvisOfRecetteDTO>> GetAvisOfRecette(int id)
        {
            try
            {
                List<AvisOfRecetteDTO> avis = (await _avisRepository.GetAvisByRecetteId(id)).Select(a => new AvisOfRecetteDTO
                {
                    id_utilisateur = a.id_utilisateur,
                    note = a.note,
                    commentaire = a.commentaire
                }).ToList();

                return avis;
            }
            catch (Exception ex)
            {
                throw new Exception("Error", ex);
            }
        }
    }
}
