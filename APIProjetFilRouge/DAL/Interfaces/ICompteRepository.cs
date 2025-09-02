using APIProjetFilRouge.Models.BussinessObjects;

namespace APIProjetFilRouge.DAL.Interfaces
{
    public interface ICompteRepository
    {
        Task<Compte> GetCompteById(int id);
    }
}
