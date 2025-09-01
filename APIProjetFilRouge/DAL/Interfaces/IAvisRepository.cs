using APIProjetFilRouge.Models.BussinessObjects;

namespace APIProjetFilRouge.DAL.Interfaces
{
    public interface IAvisRepository
    {
        public Task<List<Avis>> GetAllAvis();
    }
}
