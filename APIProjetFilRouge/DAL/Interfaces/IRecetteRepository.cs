using APIProjetFilRouge.Models.BussinessObjects;

namespace APIProjetFilRouge.DAL.Interfaces
{
    public interface IRecetteRepository
    {
        Task<List<Recette>> GetAllRecettes();
    }
}
