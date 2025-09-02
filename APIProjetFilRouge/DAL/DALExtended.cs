using APIProjetFilRouge.DAL.Interfaces;
using APIProjetFilRouge.DAL.Repositories;

namespace APIProjetFilRouge.DAL
{
    public static class DALExtended
    {
        public static void AddDal(this IServiceCollection services)
        {
            services.AddTransient<IAvisRepository, AvisRepository>();
            services.AddTransient<ICategorieRepository, CategorieRepository>();
            services.AddTransient<ICompteRepository, CompteRepository>();
            services.AddTransient<IEtapeRepository, EtapeRepository>();
            services.AddTransient<IIngredientRepository, IngredientRepository>();
            services.AddTransient<IRecetteRepository, RecetteRepository>();
        }
    }
}
