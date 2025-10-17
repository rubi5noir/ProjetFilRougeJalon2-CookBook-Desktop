using APIProjetFilRouge.Models;
using System.Data;

namespace APIProjetFilRouge.DAL.Session
{
    public abstract class BaseSession : IDBSession
    {
        public DatabaseProviderName? DatabaseProviderName { get; protected set; }
#pragma warning disable CS8618 // Un champ non-nullable doit contenir une valeur autre que Null lors de la fermeture du constructeur. Envisagez d’ajouter le modificateur « required » ou de déclarer le champ comme pouvant accepter la valeur Null.
        public IDbConnection Connection { get; protected set; }
#pragma warning restore CS8618 // Un champ non-nullable doit contenir une valeur autre que Null lors de la fermeture du constructeur. Envisagez d’ajouter le modificateur « required » ou de déclarer le champ comme pouvant accepter la valeur Null.
#pragma warning disable CS8618 // Un champ non-nullable doit contenir une valeur autre que Null lors de la fermeture du constructeur. Envisagez d’ajouter le modificateur « required » ou de déclarer le champ comme pouvant accepter la valeur Null.
        public IDbTransaction Transaction { get; private set; }
#pragma warning restore CS8618 // Un champ non-nullable doit contenir une valeur autre que Null lors de la fermeture du constructeur. Envisagez d’ajouter le modificateur « required » ou de déclarer le champ comme pouvant accepter la valeur Null.
        public bool HasActiveTransaction => Transaction != null;

        public void BeginTransaction()
        {
            if (Transaction == null)
            {
                if (Connection?.State != ConnectionState.Open)
                    Connection?.Open();

#pragma warning disable CS8601 // Existence possible d'une assignation de référence null.
                Transaction = Connection?.BeginTransaction();
#pragma warning restore CS8601 // Existence possible d'une assignation de référence null.
            }
        }

        public void Commit()
        {
            Transaction?.Commit();
#pragma warning disable CS8625 // Impossible de convertir un littéral ayant une valeur null en type référence non-nullable.
            Transaction = null;
#pragma warning restore CS8625 // Impossible de convertir un littéral ayant une valeur null en type référence non-nullable.
            Connection?.Close();
        }

        public void Rollback()
        {
            Transaction?.Rollback();
#pragma warning disable CS8625 // Impossible de convertir un littéral ayant une valeur null en type référence non-nullable.
            Transaction = null;
#pragma warning restore CS8625 // Impossible de convertir un littéral ayant une valeur null en type référence non-nullable.
            Connection?.Close();
        }

        #region IDisposable Support

        private bool _disposed = false;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Cette méthode doit être surchargée (override) dans les classes dérivées
        // si elles contiennent des ressources managées. Pour cela elle est virtuelle (virtual).
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    // Libérer les ressources managées
                    Transaction?.Dispose();
                    Connection?.Dispose();
                }

                // Libérer les ressources non managées ici si nécessaire

                _disposed = true;
            }
        }

        #endregion IDisposable Support
    }
}
