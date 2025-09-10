using APIProjetFilRouge.DAL.Interfaces;
using APIProjetFilRouge.DAL.Session;
using APIProjetFilRouge.Models.BussinessObjects;
using Dapper;

namespace APIProjetFilRouge.DAL.Repositories
{
    public class EtapeRepository : IEtapeRepository
    {
        private const string etapeTable = "etapes";

        readonly IDBSession _dbSession;
        public EtapeRepository(IDBSession dbSession)
        {
            _dbSession = dbSession;
        }

        #region Queries

        private const string _queryGetEtapesOfRecette =
            "SELECT " +
            "numero, id_recette, texte " +
            $"FROM {etapeTable} " +
            "WHERE id_recette = @IdRecette " +
            "ORDER BY numero";

        #endregion

        #region Getter

        public async Task<List<Etape>> GetEtapesOfRecetteAsync(int id)
        {
            List<Etape> etapes;

            etapes = (await _dbSession.Connection.QueryAsync<Etape>(_queryGetEtapesOfRecette, new { IdRecette = id })).ToList();

            return etapes;
        }

        #endregion
    }
}
