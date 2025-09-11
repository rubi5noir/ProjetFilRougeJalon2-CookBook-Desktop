using APIProjetFilRouge.Models.BussinessObjects;
using APIProjetFilRouge.Models.DataTransfertObjects.Between;

namespace APIProjetFilRouge.BLL.Interfaces
{
    public interface ICompteService
    {
        Task<Compte> GetAllComptesAsync(int id);

        /// <summary>
        /// Retrieves the account information by their ID.
        /// </summary>
        /// <param name="Createur">ID of the account</param>
        /// <returns></returns>
        Task<Compte> GetCompteByIdAsync(int id);

        Task<int> CreateCompteAsync(Compte compte);

        Task<int> DeleteCompteAsync(int id);
    }
}
