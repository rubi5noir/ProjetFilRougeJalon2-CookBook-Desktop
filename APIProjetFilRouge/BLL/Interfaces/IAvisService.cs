using APIProjetFilRouge.DAL.Interfaces;
using APIProjetFilRouge.Models.DataTransfertObjects.Out;

namespace APIProjetFilRouge.BLL.Interfaces
{
    public interface IAvisService
    {
        public Task<AverageNoteDTO> GetAverageNoteOfAllRecettes();
    }
}
