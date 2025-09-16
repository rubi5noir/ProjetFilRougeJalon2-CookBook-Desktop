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

        #region Queries GET

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

        #region Queries SET

        private const string _queryCreateCompte =
            $"INSERT INTO {compteTable} " +
            "(identifiant, nom, prenom, email, password, admin) " +
            "VALUES(@identifiant, @nom, @prenom, @email, @password, @admin) " +
            "RETURNING id;";

        private const string _queryUpdateCompte =
            $"UPDATE {compteTable} " +
            "SET identifiant = @identifiant " +
            "WHERE id = @id";

        private const string _queryDeleteCompte =
            $"DELETE FROM {compteTable} " +
            "WHERE id = @id";

        #endregion

        #endregion

        #region Methods

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

            compte = await _dbSession.Connection.QuerySingleAsync<Compte>(_queryGetCompteById, new
            {
                Id = id
            });

            return compte;
        }

        #endregion

        #region Setter

        public async Task<int> CreateCompteAsync(Compte compte)
        {
            
            int newId = await _dbSession.Connection.QuerySingleAsync<int>(_queryCreateCompte, new
            {
                compte.identifiant,
                compte.nom,
                compte.prenom,
                compte.email,
                compte.password,
                compte.admin
            });
            return newId;
        }

        public async Task<int> UpdateCompteAsync(Compte compte)
        {
            int rowsAffected = await _dbSession.Connection.ExecuteAsync(_queryUpdateCompte,new
            {
                compte.identifiant,
                compte.id
            });
            return rowsAffected;
        }

        public async Task<int> DeleteCompteAsync(int id)
        {
            int rowsAffected = await _dbSession.Connection.ExecuteAsync(_queryDeleteCompte, new
            {
                id = id
            });
            return rowsAffected;
        }

        #endregion

        #endregion
    }
}
