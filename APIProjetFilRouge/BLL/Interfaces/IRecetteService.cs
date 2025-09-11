using APIProjetFilRouge.Models.BussinessObjects;
using APIProjetFilRouge.Models.DataTransfertObjects.Out;

namespace APIProjetFilRouge.BLL.Interfaces
{
    public interface IRecetteService
    {

        /// <summary>
        /// Retrieves a list of recipes formatted for vignettes
        /// </summary>
        /// <returns>
        /// <para>A list of RecetteForVignetteDTO objects representing the recipes for vignettes</para>
        /// <para>Throws an exception if an error occurs while processing the request</para>
        /// </returns>
        Task<List<Recette>> GetRecetteVignetteAsync();

        /// <summary>
        /// Retrieves detailed information about a recipe by it's ID
        /// </summary>
        /// <param name="id">ID of the recipe</param>
        /// <returns></returns>
        Task<Recette> GetRecetteByIdAsync(int id);

        Task<int> CreateRecetteAsync(Recette recette);

        Task<int> UpdateRecetteAsync(Recette recette);

        Task<int> DeleteRecetteAsync(int id);
    }
}
