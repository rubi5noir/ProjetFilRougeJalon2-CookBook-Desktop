using APIProjetFilRouge.Models;
using System.Data;

namespace APIProjetFilRouge.DAL.Session
{
    public interface IDBSession : IDisposable
    {
        DatabaseProviderName? DatabaseProviderName { get; }
        IDbConnection Connection { get; }
    }
}
