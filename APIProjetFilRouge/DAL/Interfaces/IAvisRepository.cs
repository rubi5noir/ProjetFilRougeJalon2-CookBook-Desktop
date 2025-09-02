using APIProjetFilRouge.Models.BussinessObjects;

namespace APIProjetFilRouge.DAL.Interfaces
{
    public interface IAvisRepository
    {
        public Task<List<Avis>> GetAllAvis();
        public Task<List<Avis>> GetAvisByRecetteId(int idRecette);
    }
}
