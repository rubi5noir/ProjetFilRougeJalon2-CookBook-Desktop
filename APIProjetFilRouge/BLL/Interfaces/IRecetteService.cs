using APIProjetFilRouge.Models.BussinessObjects;
using APIProjetFilRouge.Models.DataTransfertObjects.Out;

namespace APIProjetFilRouge.BLL.Interfaces
{
    public interface IRecetteService
    {
        Task<List<Recette>> GetRecetteVignette();
        Task<Recette> GetRecetteById(int id);
    }
}
