using FluentValidation;

namespace APIProjetFilRouge.Models
{
    public enum DatabaseProviderName
    {
        MariaDB,
        MySQL,
        SQLServer,
        PostgreSQL,
        Oracle
    }

    public class DatabaseSettings : IDatabaseSettings
    {
#pragma warning disable CS8618 // Un champ non-nullable doit contenir une valeur autre que Null lors de la fermeture du constructeur. Envisagez d’ajouter le modificateur « required » ou de déclarer le champ comme pouvant accepter la valeur Null.
        public string ConnectionString { get; set; }
#pragma warning restore CS8618 // Un champ non-nullable doit contenir une valeur autre que Null lors de la fermeture du constructeur. Envisagez d’ajouter le modificateur « required » ou de déclarer le champ comme pouvant accepter la valeur Null.
        public DatabaseProviderName? DatabaseProviderName { get; set; }
    }

    public class DatabaseSettingsValidator : AbstractValidator<DatabaseSettings>
    {
        public DatabaseSettingsValidator()
        {
            var connectionMessage = "La chaîne de connexion est invalide.";
            var providerMessage = $"Le type de base de données est invalide. Valeurs possibles : {string.Join(", ", Enum.GetNames(typeof(DatabaseProviderName)))}";

            RuleFor(x => x.ConnectionString)
                .Cascade(CascadeMode.Stop)
                .NotNull().WithMessage(connectionMessage)
                .NotEmpty().WithMessage(connectionMessage);

            RuleFor(x => x.DatabaseProviderName)
                .Cascade(CascadeMode.Stop)
                .NotNull().WithMessage(providerMessage)
                .IsInEnum().WithMessage(providerMessage);
        }
    }
}
