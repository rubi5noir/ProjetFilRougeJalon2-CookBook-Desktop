using APIProjetFilRouge.Models.BussinessObjects;
using APIProjetFilRouge.Models.DataTransfertObjects.Between;

namespace APIProjetFilRouge.BLL.Interfaces
{
    public interface IEtapeService
    {
        Task<List<Etape>> GetEtapesOfRecette(int id);
    }
}
