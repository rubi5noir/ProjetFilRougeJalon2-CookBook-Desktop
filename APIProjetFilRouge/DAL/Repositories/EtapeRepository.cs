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
            "WHERE id_recette = id_recette AND numero = @numero";

        private const string _queryUpdateEtapeWithOldNum =
            $"UPDATE {etapeTable} " +
            "SET numero = @numero , texte = @texte " +
            "WHERE id_recette = id_recette AND numero = @oldnumero";

        private const string _queryDeleteEtape =
            $"DELETE FROM {etapeTable} " +
            "WHERE id_recette = @id_recette AND numero = @numero";

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
            }, transaction: _dbSession.Transaction)).ToList();

            return etapes;
        }

        #endregion

        #region Setter

        public async Task<int> CreateEtapeAsync(Etape etape)
        {
            var result = await _dbSession.Connection.ExecuteAsync(_queryCreateEtape, new
            {
                etape.id_recette,
                etape.numero,
                etape.texte
            }, transaction: _dbSession.Transaction);

            return result;
        }

        public async Task<int> UpdateEtapeAsync(int num, Etape etape)
        {
            if (num == 0)
            {
                var result = await _dbSession.Connection.ExecuteAsync(_queryUpdateEtape, new
                {
                    texte = etape.texte,
                    id_recette = etape.id_recette,
                    numero = etape.numero
                }, transaction: _dbSession.Transaction);
                return result;
            }
            else
            {
                var result = await _dbSession.Connection.ExecuteAsync(_queryUpdateEtapeWithOldNum, new
                {
                    texte = etape.texte,
                    id_recette = etape.id_recette,
                    numero = etape.numero,
                    oldnumero = num
                }, transaction: _dbSession.Transaction);
                return result;
            }

        }

        public async Task<int> DeleteEtapeAsync(int id_recette, int numero)
        {
            var result = await _dbSession.Connection.ExecuteAsync(_queryDeleteEtape, new
            {
                id_recette,
                numero
            }, transaction: _dbSession.Transaction);
            return result;
        }

        #endregion

        #endregion
    }
}
