using APIProjetFilRouge.BLL.Interfaces;

namespace APIProjetFilRouge.BLL.Services
{
    public static class ServiceExtended
    {
        public static void AddBll(this IServiceCollection services)
        {
            services.AddTransient<IAvisService, AvisService>();
            services.AddTransient<ICategorieService, CategorieService>();
            services.AddTransient<ICompteService, CompteService>();
            services.AddTransient<IEtapeService, EtapeService>();
            services.AddTransient<IHomeService, HomeService>();
            services.AddTransient<IIngredientService, IngredientService>();
            services.AddTransient<IRecetteService, RecetteService>();
        }
    }
}
