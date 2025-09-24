namespace APIProjetFilRouge.BLL.Interfaces
{
    public interface IJwtTokenService
    {
        string GenerateToken(string username, params string[] roles);
    }
}
