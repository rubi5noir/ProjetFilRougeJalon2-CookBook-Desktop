
using APIProjetFilRouge.BLL.Services;
using APIProjetFilRouge.DAL;
using APIProjetFilRouge.Models;
using FluentValidation;


namespace APIProjetFilRouge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Build and validate settings, then add to the container.
            var settings = BuildSettings<IDatabaseSettings, DatabaseSettings, DatabaseSettingsValidator>(builder, "DatabaseSettings");

            // Add services to the container.
            builder.Services.AddBll();
            builder.Services.AddDal(settings);

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            app.UseMiddleware<GlobalExceptionMiddleware>();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }







        //Fonction Generique pour build la connexion a la DB peut importe laquelle
        private static TService BuildSettings<TService, TImplementation, TValidator>(WebApplicationBuilder builder, string sectionName) where TService : class where TImplementation : TService, new() where TValidator : AbstractValidator<TImplementation>, new()
        {
            TImplementation settings = new();
            builder.Configuration.GetSection(sectionName).Bind(settings);
            TValidator validator = new();

            var validationResult = validator.Validate(settings);

            if (!validationResult.IsValid)
            {
                var logger = builder.Logging.Services.BuildServiceProvider().GetRequiredService<ILoggerFactory>().CreateLogger("Startup");

                logger.LogError("Erreur de validation des paramètres de configuration ({SectionName}) :", sectionName);
                foreach (var error in validationResult.Errors)
                {
                    logger.LogError(" - {Property}: {ErrorMessage}", error.PropertyName, error.ErrorMessage);
                }

                Console.WriteLine("\nL'application a été arrêtée en raison d'une configuration invalide.");
                Environment.Exit(1); // Arrêt propre
            }

            builder.Services.AddSingleton<TService>(settings);
            return settings;
        }
    }
}

