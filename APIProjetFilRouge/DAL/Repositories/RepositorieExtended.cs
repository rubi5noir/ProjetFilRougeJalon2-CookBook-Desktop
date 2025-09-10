using APIProjetFilRouge.DAL.Interfaces;

namespace APIProjetFilRouge.DAL.Repositories
{
    public static class RepositorieExtended
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
