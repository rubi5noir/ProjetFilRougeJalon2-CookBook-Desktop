using APIProjetFilRouge;
using APIProjetFilRouge.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITestIntegration.Fixture
{
#pragma warning disable S101 // Types should be named in PascalCase
    public class APIWebApplicationFactory : WebApplicationFactory<Program>
#pragma warning restore S101 // Types should be named in PascalCase
    {

#pragma warning disable CS8618 // Un champ non-nullable doit contenir une valeur autre que Null lors de la fermeture du constructeur. Envisagez d’ajouter le modificateur « required » ou de déclarer le champ comme pouvant accepter la valeur Null.
        public IConfiguration Configuration { get; set; }
#pragma warning restore CS8618 // Un champ non-nullable doit contenir une valeur autre que Null lors de la fermeture du constructeur. Envisagez d’ajouter le modificateur « required » ou de déclarer le champ comme pouvant accepter la valeur Null.


        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {

            builder.ConfigureAppConfiguration(config =>
            {
                Configuration = new ConfigurationBuilder()
                    .AddJsonFile("appSettings.Integrations.json")
                    .Build();
                config.AddConfiguration(Configuration);

            });

            //IOC:
            //serviceCollection => read&Write
            //serviceProvider => readOnly 

            builder.ConfigureServices(sc =>
            {
                //Supprimer le singleton dbsettings
                var databaseSettings = sc.FirstOrDefault(service => service is IDatabaseSettings);
#pragma warning disable CS8604 // Existence possible d'un argument de référence null.
                sc.Remove(databaseSettings);
#pragma warning restore CS8604 // Existence possible d'un argument de référence null.

                //Ajouter le nouveau singleton
#pragma warning disable CS8601 // Existence possible d'une assignation de référence null.
                sc.AddSingleton<IDatabaseSettings>(sp =>
                new DatabaseSettings()
                {

                    ConnectionString = Configuration.GetSection("DatabaseSettings").GetValue<string>("ConnectionString"),
                    DatabaseProviderName = Configuration.GetSection("DatabaseSettings").GetValue<DatabaseProviderName>("DatabaseProviderName")
                });
#pragma warning restore CS8601 // Existence possible d'une assignation de référence null.


            });
            base.ConfigureWebHost(builder);

        }


    }

}
