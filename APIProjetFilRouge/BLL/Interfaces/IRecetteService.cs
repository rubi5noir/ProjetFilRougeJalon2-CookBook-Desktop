using APIProjetFilRouge.Models.DataTransfertObjects.Out;

namespace APIProjetFilRouge.BLL.Interfaces
{
    public interface IRecetteService
    {
        Task<List<RecetteForVignetteDTO>> GetRecetteForVignette();
        Task<RecetteDetailsDTO> GetRecetteDetailsById(int id);
    }
}
