using APIProjetFilRouge.DAL.Interfaces;
using APIProjetFilRouge.Models.DataTransfertObjects.Between;

namespace APIProjetFilRouge.BLL.Interfaces
{
    public interface IAvisService
    {
        public Task<AverageNoteDTO> GetAverageNoteOfAllRecettes();
        public Task<List<AvisOfRecetteDTO>> GetAvisOfRecette(int id);
    }
}
