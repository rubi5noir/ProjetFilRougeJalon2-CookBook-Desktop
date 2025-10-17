using APIProjetFilRouge.DAL.Interfaces;
using APIProjetFilRouge.DAL.Repositories;
using APIProjetFilRouge.DAL.Session;
using APIProjetFilRouge.DAL.Session.PostGres;
using APIProjetFilRouge.DAL.UnitsOfWork;
using APIProjetFilRouge.Models;
using Microsoft.AspNetCore.Http;
using static Dapper.SqlMapper;

namespace APIProjetFilRouge.DAL
{
    public static class DalExtended
    {
        public static void AddDal(this IServiceCollection services, IDatabaseSettings settings)
        {
            switch (settings.DatabaseProviderName)
            {
                case DatabaseProviderName.PostgreSQL:
                    services.AddScoped<IDBSession, PostGresDBSession>();
                    break;
            }

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IAvisRepository, AvisRepository>();
            services.AddTransient<ICategorieRepository, CategorieRepository>();
            services.AddTransient<ICompteRepository, CompteRepository>();
            services.AddTransient<IEtapeRepository, EtapeRepository>();
            services.AddTransient<IIngredientRepository, IngredientRepository>();
            services.AddTransient<IRecetteRepository, RecetteRepository>();
        }
    }
}
