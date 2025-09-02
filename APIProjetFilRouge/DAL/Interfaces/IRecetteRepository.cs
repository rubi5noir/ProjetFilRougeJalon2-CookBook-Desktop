using APIProjetFilRouge.Models.BussinessObjects;

namespace APIProjetFilRouge.DAL.Interfaces
{
    public interface IRecetteRepository
    {
        Task<List<Recette>> GetAllRecettes();
        Task<Recette> GetRecetteById(int id);
    }
}
