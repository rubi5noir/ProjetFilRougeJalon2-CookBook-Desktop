using APIProjetFilRouge.Models;
using Npgsql;

namespace APIProjetFilRouge.DAL.Session.PostGres
{
    public class PostGresDBSession : BaseSession
    {
        public PostGresDBSession(IDatabaseSettings settings)
        {
            Connection = new NpgsqlConnection(settings.ConnectionString);
            DatabaseProviderName = settings.DatabaseProviderName;
        }
    }
}
