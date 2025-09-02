using APIProjetFilRouge.Models.DataTransfertObjects.Between;

namespace APIProjetFilRouge.BLL.Interfaces
{
    public interface IEtapeService
    {
        Task<List<EtapeDTO>> GetEtapesOfRecette(int id);
    }
}
