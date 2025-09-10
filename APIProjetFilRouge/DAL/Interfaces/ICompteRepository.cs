using APIProjetFilRouge.Models.BussinessObjects;

namespace APIProjetFilRouge.DAL.Interfaces
{
    public interface ICompteRepository
    {
        Task<List<Compte>> GetAllComptesAsync();

        /// <summary>
        /// Retrieves an account by its ID.
        /// </summary>
        /// <param name="id">ID of the account</param>
        /// <returns></returns>
        Task<Compte> GetCompteByIdAsync(int id);
    }
}
