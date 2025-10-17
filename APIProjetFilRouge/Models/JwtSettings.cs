﻿using FluentValidation;

namespace APIProjetFilRouge.Models
{
    public class JwtSettings : IJwtSettings
    {
#pragma warning disable CS8618 // Un champ non-nullable doit contenir une valeur autre que Null lors de la fermeture du constructeur. Envisagez d’ajouter le modificateur « required » ou de déclarer le champ comme pouvant accepter la valeur Null.
        public string Secret { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public int ExpirationMinutes { get; set; }
 #pragma warning restore CS8618 // Un champ non-nullable doit contenir une valeur autre que Null lors de la fermeture du constructeur. Envisagez d’ajouter le modificateur « required » ou de déclarer le champ comme pouvant accepter la valeur Null.
   }

    public class JwtSettingsValidator : AbstractValidator<JwtSettings>
    {
        public JwtSettingsValidator()
        {
            const int MinSecretLength = 32;
            RuleFor(x => x.Secret)
                .NotNull().NotEmpty().WithMessage("Le secret JWT est requis.")
                .MinimumLength(MinSecretLength)
                .WithMessage($"Le secret JWT doit contenir au moins {MinSecretLength} caractères.");

            RuleFor(x => x.Issuer)
                .NotNull().NotEmpty().WithMessage("L'émetteur (Issuer) est requis.");

            RuleFor(x => x.Audience)
                .NotNull().NotEmpty().WithMessage("L'audience (Audience) est requise.");

            RuleFor(x => x.ExpirationMinutes)
                .GreaterThan(0).WithMessage("La durée d'expiration doit être supérieure à 0.");
        }
    }
}
