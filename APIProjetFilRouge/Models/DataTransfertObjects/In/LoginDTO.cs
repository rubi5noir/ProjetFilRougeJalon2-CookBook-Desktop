using FluentValidation;

namespace APIProjetFilRouge.Models.DataTransfertObjects.In
{
    /// <summary>
    /// DTO utilisé pour la connexion d'un utilisateur.
    /// </summary>
#pragma warning disable S101 // Types should be named in PascalCase
    public class LoginDTO
#pragma warning restore S101 // Types should be named in PascalCase
    {
        /// <summary>
        /// Nom d'utilisateur de l'utilisateur.
        /// </summary>
#pragma warning disable CS8618 // Un champ non-nullable doit contenir une valeur autre que Null lors de la fermeture du constructeur. Envisagez d’ajouter le modificateur « required » ou de déclarer le champ comme pouvant accepter la valeur Null.
        public string Username { get; set; }
#pragma warning restore CS8618 // Un champ non-nullable doit contenir une valeur autre que Null lors de la fermeture du constructeur. Envisagez d’ajouter le modificateur « required » ou de déclarer le champ comme pouvant accepter la valeur Null.

        /// <summary>
        /// Mot de passe de l'utilisateur.
        /// </summary>
#pragma warning disable CS8618 // Un champ non-nullable doit contenir une valeur autre que Null lors de la fermeture du constructeur. Envisagez d’ajouter le modificateur « required » ou de déclarer le champ comme pouvant accepter la valeur Null.
        public string Password { get; set; }
#pragma warning restore CS8618 // Un champ non-nullable doit contenir une valeur autre que Null lors de la fermeture du constructeur. Envisagez d’ajouter le modificateur « required » ou de déclarer le champ comme pouvant accepter la valeur Null.
    }

    /// <summary>
    /// Validateur FluentValidation pour <see cref="LoginDTO"/>.
    /// </summary>
#pragma warning disable S101 // Types should be named in PascalCase
    public class LoginDTOValidator : AbstractValidator<LoginDTO>
#pragma warning restore S101 // Types should be named in PascalCase
    {
        /// <summary>
        /// Initialise les règles de validation pour la connexion d'un utilisateur.
        /// </summary>
        public LoginDTOValidator()
        {
            RuleFor(x => x.Username)
                .NotEmpty().WithMessage("Le nom d'utilisateur est requis.")
                .MinimumLength(3).WithMessage("Le nom d'utilisateur doit contenir au moins 3 caractères.");

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Le mot de passe est requis.")
                .MinimumLength(4).WithMessage("Le mot de passe doit contenir au moins 4 caractères.");
        }
    }
}
