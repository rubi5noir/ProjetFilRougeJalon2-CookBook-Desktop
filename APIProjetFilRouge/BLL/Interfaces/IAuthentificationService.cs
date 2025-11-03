namespace APIProjetFilRouge.BLL.Interfaces
{
    public interface IAuthentificationService
    {
        string Authenticate(string username, string password);

        // Putted here in case of future use
        string HashPassword(string password);

        bool VerifyPassword(string password, string hashedPassword);

        /// <summary>
        /// Génère un token JWT pour un utilisateur donné et ses rôles.
        /// </summary>
        /// <param name="username">Nom d'utilisateur pour lequel générer le token.</param>
        /// <param name="roles">Liste des rôles associés à l'utilisateur.</param>
        /// <returns>Le token JWT généré sous forme de chaîne.</returns>
        string GenerateToken(string username, params string[] roles);
    }
}
