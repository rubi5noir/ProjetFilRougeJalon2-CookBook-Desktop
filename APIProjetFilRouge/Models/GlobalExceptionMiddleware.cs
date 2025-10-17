using Npgsql;

namespace APIProjetFilRouge.Models
{
    public class GlobalExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<GlobalExceptionMiddleware> _logger;
        private readonly IWebHostEnvironment _env;

        public GlobalExceptionMiddleware(RequestDelegate next, ILogger<GlobalExceptionMiddleware> logger, IWebHostEnvironment env)
        {
            _next = next;
            _logger = logger;
            _env = env;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, DateTime.Now.ToString());
                await HandleExceptionAsync(context, ex);
            }
        }

        private Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            // Suivant le type d'exception, on peut retourner des codes HTTP et des réponses différentes.

            context.Response.ContentType = "application/json";
            GlobalExceptionMessage response;

            // Gestion des erreurs de base de données PostgreSQL
            if (exception is NpgsqlException npgsqlex)
            {
                // No Data (To Keep The if and else for the time being (wich is until there is some post methods in the API))
                if (npgsqlex.ErrorCode == 02000)
                {
                    context.Response.StatusCode = StatusCodes.Status400BadRequest;
                    response = new GlobalExceptionMessage
                    {
                        error = "Error",
                        details = _env.IsDevelopment() ? $"{exception.GetType().Name} : {exception.Message}" : "Aucunes Données."
                    };
                    return context.Response.WriteAsJsonAsync(response);
                }
                // Pour d'autres erreurs de base de données, on retourne une erreur serveur
                else
                {
                    context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                    response = new GlobalExceptionMessage
                    {
                        error = "Error",
                        details = _env.IsDevelopment() ? $"{exception.GetType().Name} : {exception.Message}" : "Veuillez vérifier les informations entrées."
                    };
                    return context.Response.WriteAsJsonAsync(response);
                }
            }
            // Autres types d'exceptions
            else
            {
                context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                response = new GlobalExceptionMessage
                {
                    error = "Une erreur interne est survenue.",
                    details = _env.IsDevelopment() ? $"{exception.GetType().Name} : {exception.Message}" : "Veuillez vous adresser à l'administrateur du système."
                };
                return context.Response.WriteAsJsonAsync(response);
            }
        }
    }


    public class GlobalExceptionMessage
    {
#pragma warning disable CS8618 // Un champ non-nullable doit contenir une valeur autre que Null lors de la fermeture du constructeur. Envisagez d’ajouter le modificateur « required » ou de déclarer le champ comme pouvant accepter la valeur Null.
        public string error { get; set; }
        public string details { get; set; }
    #pragma warning restore CS8618 // Un champ non-nullable doit contenir une valeur autre que Null lors de la fermeture du constructeur. Envisagez d’ajouter le modificateur « required » ou de déclarer le champ comme pouvant accepter la valeur Null.
}
}
