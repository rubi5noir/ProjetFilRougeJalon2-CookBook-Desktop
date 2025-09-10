using APIProjetFilRouge.Models.BussinessObjects;

namespace APIProjetFilRouge.DAL.Interfaces
{
    public interface IRecetteRepository
    {
        /// <summary>
        /// Retrieves all recipes from the database.
        /// </summary>
        /// <returns>
        /// <para>A list of Recette objects representing all recipes.</para>
        /// <para>Throws an exception if an error occurs while retrieving the recipes.</para>
        /// </returns>
        Task<List<Recette>> GetAllRecettesAsync();

        /// <summary>
        /// Retrieves a specific recipe by its ID.
        /// </summary>
        /// <param name="id">ID of the recipe</param>
        /// <returns></returns>
        Task<Recette> GetRecetteByIdAsync(int id);
    }
}
