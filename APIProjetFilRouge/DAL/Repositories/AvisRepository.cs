using APIProjetFilRouge.DAL.Interfaces;
using APIProjetFilRouge.Models.BussinessObjects;
using Dapper;
using Npgsql;

namespace APIProjetFilRouge.DAL.Repositories
{
    public class AvisRepository : IAvisRepository
    {
        private readonly string _connectionString = "Server=localhost;database=CookBook;uid=postgres;Pwd=password;Port=5435";

        private readonly string _queryGetAllAvis = 
            "SELECT " +
            "id_recette, id_utilisateur, note, commentaire " +
            "FROM avis";

        /// <summary>
        /// Retrieves all reviews from the database.
        /// </summary>
        /// <returns>
        /// <para>A list of Avis objects representing all reviews.</para>
        /// <para>Throws an exception if an error occurs while retrieving the reviews.</para>
        /// </returns>
        public async Task<List<Avis>> GetAllAvis()
        {
            try
            {
                List<Avis> Avis = new List<Avis>();
                using (var connexion = new NpgsqlConnection(_connectionString))
                {
                    Avis = (await connexion.QueryAsync<Avis>(_queryGetAllAvis)).ToList();
                }
                return Avis;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving all reviews.", ex);
            }
        }
    }
}
