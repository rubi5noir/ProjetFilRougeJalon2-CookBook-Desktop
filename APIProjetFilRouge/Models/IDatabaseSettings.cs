namespace APIProjetFilRouge.Models
{
    public interface IDatabaseSettings
    {
        string ConnectionString { get; set; }
        DatabaseProviderName? DatabaseProviderName { get; set; }
    }
}
