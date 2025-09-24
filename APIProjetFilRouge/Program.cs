
using APIProjetFilRouge.BLL.Services;
using APIProjetFilRouge.DAL;
using APIProjetFilRouge.Models;
using FluentValidation;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Reflection;
using System.Security.Claims;
using System.Text;


namespace APIProjetFilRouge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Ajout de FluentValidation au conteneur de services.
            builder.Services.AddValidatorsFromAssemblyContaining<Program>();

            // Construction et validation de DatabaseSettings, puis ajout au conteneur.
            if (TryBuildSettings<IDatabaseSettings, DatabaseSettings, DatabaseSettingsValidator>(builder, "DatabaseSettings", out DatabaseSettings dbSettings))
                builder.Services.AddSingleton<IDatabaseSettings>(dbSettings);
            else
                return;

            // Construction et validation de JwtSettings, puis ajout au conteneur.
            if (TryBuildSettings<IJwtSettings, JwtSettings, JwtSettingsValidator>(builder, "JwtSettings", out JwtSettings jwtSettings))
                builder.Services.AddSingleton<IJwtSettings>(jwtSettings);
            else
                return;

            // Add services to the container.
            builder.Services.AddBll();
            builder.Services.AddDal(dbSettings);

            // Ajout des contr�leurs au conteneur de services avec une politique d'autorisation globale.
            // Cette configuration applique automatiquement l'attribut [Authorize] � tous les contr�leurs et actions,
            // ce qui signifie que toutes les requ�tes n�cessitent un utilisateur authentifi� par d�faut.
            // Les actions ou contr�leurs qui doivent rester accessibles sans authentification
            // peuvent �tre annot�s avec [AllowAnonymous].
            builder.Services.AddControllers(options =>
            {
                var policy = new AuthorizationPolicyBuilder()
                    .RequireAuthenticatedUser()
                    .Build();
                options.Filters.Add(new AuthorizeFilter(policy));
            });

            // Configuration de l'authentification JWT.
            // Cette section configure le middleware d'authentification pour utiliser le sch�ma "Bearer" avec JWT.
            // Elle d�finit �galement les param�tres de validation du token, tels que l'�metteur, l'audience, la dur�e de vie
            // et la cl� de signature. Ces param�tres sont essentiels pour garantir que seuls les tokens valides et �mis
            // par une source de confiance sont accept�s.
            //
            // Le champ RoleClaimType est d�fini pour permettre l'utilisation de l'attribut [Authorize(Roles = "...")].
            builder.Services.AddAuthentication(options =>
            {
                // D�finit le sch�ma par d�faut pour l'authentification et les d�fis (401 Unauthorized).
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                // Param�tres de validation du token JWT.
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true, // V�rifie que le token provient de l'�metteur attendu.
                    ValidateAudience = true, // V�rifie que le token est destin� � l'audience pr�vue.
                    ValidateLifetime = true, // V�rifie que le token n'est pas expir�.
                    ValidateIssuerSigningKey = true, // V�rifie que la signature du token est valide.

                    ValidIssuer = jwtSettings.Issuer, // �metteur attendu.
                    ValidAudience = jwtSettings.Audience, // Audience attendue.
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.Secret)), // Cl� secr�te utilis�e pour signer le token.

                    RoleClaimType = ClaimTypes.Role // Permet d'utiliser les r�les dans les contr�leurs via [Authorize(Roles = "...")].
                };
            });

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(options =>
            {
                // Affichage du titre et de la version dans Swagger UI
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "Biblioth�que", Version = "v1" });

                // Inclure les commentaires XML (Le fichier XML doit �tre g�n�r� dans les propri�t�s du projet)
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                if (File.Exists(xmlPath))
                    options.IncludeXmlComments(xmlPath, true);

                // D�finition de la s�curit� JWT dans Swagger
                options.AddSecurityDefinition("jwt", new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Description = "Entrez le token JWT.\n\nExemple : eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9..."
                });

                // Application de la s�curit� globalement (toutes les op�rations dans swagger)
                options.AddSecurityRequirement(new Microsoft.OpenApi.Models.OpenApiSecurityRequirement
                {
                    {
                        new Microsoft.OpenApi.Models.OpenApiSecurityScheme
                        {
                            Reference = new Microsoft.OpenApi.Models.OpenApiReference
                            {
                                Type = Microsoft.OpenApi.Models.ReferenceType.SecurityScheme,
                                Id = "jwt"
                            }
                        },
                        Array.Empty<string>()
                    }
                });
            });

            var app = builder.Build();

            app.UseMiddleware<GlobalExceptionMiddleware>();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthentication(); // Toujours avant UseAuthorization
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }


        /// <summary>
        /// Tente de construire et de valider une section de configuration, puis retourne l'instance valid�e.
        /// </summary>
        /// <typeparam name="TService">Type de service � enregistrer.</typeparam>
        /// <typeparam name="TImplementation">Type d'impl�mentation de la configuration.</typeparam>
        /// <typeparam name="TValidator">Type du validateur FluentValidation.</typeparam>
        /// <param name="builder">Le builder de l'application.</param>
        /// <param name="sectionName">Nom de la section de configuration.</param>
        /// <param name="settings">Instance valid�e de la configuration.</param>
        /// <returns>True si la configuration est valide, sinon false.</returns>
        public static bool TryBuildSettings<TService, TImplementation, TValidator>(
            WebApplicationBuilder builder,
            string sectionName,
            out TImplementation settings)
            where TService : class
            where TImplementation : class, TService, new()
            where TValidator : AbstractValidator<TImplementation>, new()
        {
            // Liaison de la configuration
            settings = new TImplementation();
            builder.Configuration.GetSection(sectionName).Bind(settings);

            // Cr�ation du logger via LoggerFactory
            using var loggerFactory = LoggerFactory.Create(logging =>
            {
                logging.AddConsole();
                logging.AddDebug();
                logging.SetMinimumLevel(LogLevel.Information);
            });
            var logger = loggerFactory.CreateLogger("Startup");

            // Validation avec FluentValidation
            var validator = new TValidator();
            var result = validator.Validate(settings);

            if (result.IsValid)
                logger.LogInformation("Configuration '{SectionName}' charg�e et valid�e.", sectionName);
            else
            {
                logger.LogError("Configuration invalide dans la section '{SectionName}'", sectionName);
                foreach (var error in result.Errors)
                    logger.LogError(" - {Property}: {ErrorMessage}", error.PropertyName, error.ErrorMessage);

                settings = null;
            }

            return result.IsValid;
        }
    }
}

