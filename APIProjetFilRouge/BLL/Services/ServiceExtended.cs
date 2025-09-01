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

        public static void AddDal(this IServiceCollection services)
        {
            services.AddTransient<APIProjetFilRouge.DAL.Interfaces.IAvisRepository, APIProjetFilRouge.DAL.Repositories.AvisRepository>();
            services.AddTransient<APIProjetFilRouge.DAL.Interfaces.ICategorieRepository, APIProjetFilRouge.DAL.Repositories.CategorieRepository>();
            services.AddTransient<APIProjetFilRouge.DAL.Interfaces.ICompteRepository, APIProjetFilRouge.DAL.Repositories.CompteRepository>();
            services.AddTransient<APIProjetFilRouge.DAL.Interfaces.IEtapeRepository, APIProjetFilRouge.DAL.Repositories.EtapeRepository>();
            services.AddTransient<APIProjetFilRouge.DAL.Interfaces.IIngredientRepository, APIProjetFilRouge.DAL.Repositories.IngredientRepository>();
            services.AddTransient<APIProjetFilRouge.DAL.Interfaces.IRecetteRepository, APIProjetFilRouge.DAL.Repositories.RecetteRepository>();
        }
    }
}
