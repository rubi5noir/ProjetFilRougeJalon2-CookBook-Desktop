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

        #region Queries GET

        private const string _queryGetEtapesOfRecette =
            "SELECT " +
            "numero, id_recette, texte " +
            $"FROM {etapeTable} " +
            "WHERE id_recette = @IdRecette " +
            "ORDER BY numero";

        #endregion

        #region Queries SET

        private const string _queryCreateEtape =
            $"INSERT INTO {etapeTable} " +
            "(id_recette, numero, texte) " +
            "VALUES(@id_recette, @numero, @texte)";

        private const string _queryUpdateEtape =
            $"UPDATE {etapeTable} " +
            "SET texte = @texte " +
            "WHERE id_recette = id_recette AND WHERE numero = @numero";

        private const string _queryDeleteEtape =
            $"DELETE FROM {etapeTable} " +
            "WHERE id_recette = @id_recette AND WHERE numero = @numero";

        #endregion

        #endregion

        #region Methods

        #region Getter

        public async Task<List<Etape>> GetEtapesOfRecetteAsync(int id)
        {
            List<Etape> etapes;

            etapes = (await _dbSession.Connection.QueryAsync<Etape>(_queryGetEtapesOfRecette, new
            {
                IdRecette = id
            })).ToList();

            return etapes;
        }

        #endregion

        #region Setter

        public async Task<int> CreateEtapeAsync(Etape etape)
        {
            var parameters = new
            {
                etape.id_recette,
                etape.numero,
                etape.texte
            };
            var result = await _dbSession.Connection.ExecuteAsync(_queryCreateEtape, parameters);
            return result;
        }

        public async Task<int> UpdateEtapeAsync(Etape etape)
        {
            var result = await _dbSession.Connection.ExecuteAsync(_queryUpdateEtape, new
            {
                texte = etape.texte,
                id_recette = etape.id_recette,
                numero = etape.numero
            });
            return result;
        }

        public async Task<int> DeleteEtapeAsync(int id_recette, int numero)
        {
            var parameters = new
            {
                id_recette,
                numero
            };
            var result = await _dbSession.Connection.ExecuteAsync(_queryDeleteEtape, parameters);
            return result;
        }

        #endregion

        #endregion
    }
}
