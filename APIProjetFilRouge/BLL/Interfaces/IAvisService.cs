using APIProjetFilRouge.DAL.Interfaces;
using APIProjetFilRouge.Models.BussinessObjects;
using APIProjetFilRouge.Models.DataTransfertObjects.Between;

namespace APIProjetFilRouge.BLL.Interfaces
{
    public interface IAvisService
    {
        public Task<List<Avis>> GetAvisOfAllRecettes();
        public Task<List<Avis>> GetAvisOfRecette(int id);
    }
}
