using APIProjetFilRouge.BLL.Interfaces;

namespace APIProjetFilRouge.BLL.Services
{
    public static class ServiceExtended
    {
        public static void AddBll(this IServiceCollection services)
        {
            services.AddTransient<ICookBookService, CookBookService>();
            services.AddTransient<IAuthentificationService, AuthentificationService>();
        }
    }
}
