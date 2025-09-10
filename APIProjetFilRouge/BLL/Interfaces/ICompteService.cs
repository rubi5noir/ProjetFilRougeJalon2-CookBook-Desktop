using APIProjetFilRouge.Models.BussinessObjects;
using APIProjetFilRouge.Models.DataTransfertObjects.Between;

namespace APIProjetFilRouge.BLL.Interfaces
{
    public interface ICompteService
    {
        /// <summary>
        /// Retrieves the creator information by their ID.
        /// </summary>
        /// <param name="Createur">ID of the creator of the recipe</param>
        /// <returns></returns>
        Task<Compte> GetCreateurByIdAsync(int Createur);
    }
}
