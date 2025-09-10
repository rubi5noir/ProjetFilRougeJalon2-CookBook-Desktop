using APIProjetFilRouge.DAL.Interfaces;
using APIProjetFilRouge.DAL.Session;
using APIProjetFilRouge.Models.BussinessObjects;
using Dapper;

namespace APIProjetFilRouge.DAL.Repositories
{
    public class CompteRepository : ICompteRepository
    {
        private const string compteTable = "utilisateurs";

        readonly IDBSession _dbSession;
        public CompteRepository(IDBSession dbSession)
        {
            _dbSession = dbSession;
        }

        #region Queries

        private const string _queryGetAllComptes =
            "SELECT " +
            "id, identifiant, nom, prenom, email, password, admin " +
            $"FROM {compteTable}";

        private const string _queryGetCompteById =
            "SELECT " +
            "id, identifiant, nom, prenom, email, password, admin " +
            $"FROM {compteTable} " +
            "WHERE id = @Id";

        #endregion

        #region Getter

        public async Task<List<Compte>> GetAllComptesAsync()
        {
            List<Compte> comptes = new List<Compte>();

            comptes = (await _dbSession.Connection.QueryAsync<Compte>(_queryGetAllComptes)).ToList();

            return comptes;
        }

        public async Task<Compte> GetCompteByIdAsync(int id)
        {
            Compte compte = new Compte();

            compte = await _dbSession.Connection.QuerySingleAsync<Compte>(_queryGetCompteById, new { Id = id });

            return compte;
        }

        #endregion
    }
}
