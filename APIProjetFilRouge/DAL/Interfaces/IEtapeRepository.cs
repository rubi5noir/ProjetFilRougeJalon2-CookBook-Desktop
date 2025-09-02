using APIProjetFilRouge.Models.BussinessObjects;

namespace APIProjetFilRouge.DAL.Interfaces
{
    public interface IEtapeRepository
    {
        Task<List<Etape>> GetEtapesOfRecette(int id);
    }
}
