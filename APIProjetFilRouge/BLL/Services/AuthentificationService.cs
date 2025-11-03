using APIProjetFilRouge.BLL.Interfaces;
using APIProjetFilRouge.DAL.Interfaces;
using APIProjetFilRouge.Models;
using APIProjetFilRouge.Models.BussinessObjects;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace APIProjetFilRouge.BLL.Services
{
    /// <summary>
    /// Service responsable de la génération des tokens JWT pour l'authentification et l'autorisation.
    /// </summary>
    public class AuthentificationService : IAuthentificationService
    {
        private readonly IJwtSettings _jwtSettings;
        private readonly ICompteRepository _compteRepository;

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="AuthentificationService"/>.
        /// </summary>
        /// <param name="jwtSettings">Paramètres de configuration JWT.</param>
        public AuthentificationService(IJwtSettings jwtSettings, ICompteRepository compteRepository)
        {
            _jwtSettings = jwtSettings;
            _compteRepository = compteRepository;
        }

        public string Authenticate(string username, string password)
        {
            Compte compte = _compteRepository.GetByIdentifiantAsync(username);

            if (compte == null)
            {
#pragma warning disable CS8603 // Existence possible d'un retour de référence null.
                return null;
#pragma warning restore CS8603 // Existence possible d'un retour de référence null.
            }

            if (VerifyPassword(password, compte.password))
            {
                string Token;

                if (compte.Role == "Admin")
                {
                    Token = GenerateToken(compte.identifiant, "Admin", "User");
                }
                else
                {
                    Token = GenerateToken(compte.identifiant, "User");
                }

                return Token;
            }
            else
            {
                return null;
            }
        }

        public string HashPassword(string password)
        {
            throw new NotImplementedException();
        }

        public bool VerifyPassword(string password, string hashedPassword)
        {
            var result = BCrypt.Net.BCrypt.Verify(password, hashedPassword);

            return result;
        }

        public string GenerateToken(string username, params string[] roles)
        {
            // Ajoute les informations de l'utilisateur dans les claims
            var claims = new List<Claim>
            {
               new(JwtRegisteredClaimNames.Sub, username), // ID utilisateur (Subject)
               new(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()), // ID du token
               new(ClaimTypes.NameIdentifier, username) // ID utilisateur (NameIdentifier)
            };

            // Ajoute les rôles de l'utilisateur dans les claims
            foreach (var role in roles)
            {
                claims.Add(new(ClaimTypes.Role, role.Trim()));
            }

            // Crée la clé de sécurité symétrique
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Secret));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            // Crée le token JWT
            var token = new JwtSecurityToken(
                issuer: _jwtSettings.Issuer,
                audience: _jwtSettings.Audience,
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(_jwtSettings.ExpirationMinutes),
                signingCredentials: creds
            );

            // Retourne le token sous forme de chaîne
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
