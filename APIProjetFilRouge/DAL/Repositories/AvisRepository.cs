using APIProjetFilRouge.DAL.Interfaces;
using APIProjetFilRouge.DAL.Session;
using APIProjetFilRouge.Models.BussinessObjects;
using Dapper;
using Npgsql;
using System.Collections.Generic;

namespace APIProjetFilRouge.DAL.Repositories
{
    public class AvisRepository : IAvisRepository
    {
        private const string avisTable = "avis";
        readonly IDBSession _dbSession;
        public AvisRepository(IDBSession dbSession)
        {
            _dbSession = dbSession;
        }

        #region Querries

        #region Querries GET

        private const string _queryGetAllAvis =
            "SELECT " +
            "id_recette, id_utilisateur, note, commentaire " +
            $"FROM {avisTable}";

        private const string _queryGetAvisByRecetteId =
            "SELECT " +
            "id_recette, id_utilisateur, note, commentaire " +
            $"FROM {avisTable} " +
            "WHERE id_recette = @Id";

        #endregion

        #region Querries SET

        private const string _queryCreateAvis =
            $"INSERT INTO {avisTable} " +
            "(id_recette, id_utilisateur, note, commentaire) " +
            "VALUES(@id_recette, @id_utilisateur, @note, @commentaire)";

        private const string _queryDeleteAvis =
            $"DELETE FROM {avisTable} " +
            "WHERE id_recette = @id_recette AND id_utilisateur = @id_utilisateur";

        #endregion

        #endregion

        #region Methods

        #region Getter

        public async Task<List<Avis>> GetAllAvisAsync()
        {
            List<Avis> Avis = new List<Avis>();

            Avis = (await _dbSession.Connection.QueryAsync<Avis>(_queryGetAllAvis)).ToList();

            return Avis;
        }

        public async Task<List<Avis>> GetAvisByRecetteIdAsync(int id)
        {
            List<Avis> Avis = new List<Avis>();

            Avis = (await _dbSession.Connection.QueryAsync<Avis>(_queryGetAvisByRecetteId, new { Id = id })).ToList();

            return Avis;
        }

        #endregion

        #region Setter

        public async Task<int> CreateAvisAsync(Avis avis)
        {
            int result;

            result = (await _dbSession.Connection.ExecuteAsync(_queryCreateAvis, new { id_recette = avis.id_recette, id_utilisateur = avis.id_utilisateur, note = avis.note, commentaire = avis.commentaire }));

            return result;
        }

        public async Task<int> DeleteAvisAsync(int id_recette, int id_utilisateur)
        {
            int result;

            result = (await _dbSession.Connection.ExecuteAsync(_queryDeleteAvis, new { id_recette = id_recette, id_utilisateur = id_utilisateur }));

            return result;
        }

        #endregion

        #endregion
    }
}
