using APIProjetFilRouge.Models.DataTransfertObjects.In;
using APIProjetFilRouge.Models.DataTransfertObjects.Out;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System.Data;
using System.Net.Http.Json;

[assembly: CollectionBehavior(DisableTestParallelization = true)]

namespace APITestIntegration.Fixture;
public abstract class IntegrationTest : IClassFixture<APIWebApplicationFactory>
{
    public HttpClient httpClient { get; set; }
    private IConfiguration _configuration { get; set; }
    protected IntegrationTest(APIWebApplicationFactory webApi)
    {
        //instancier le client
        httpClient = webApi.CreateClient();
        _configuration = webApi.Configuration;


    }

    public async Task Login(string username, string password)
    {
        var httpResponse = await httpClient.PostAsJsonAsync<LoginDTO>("/api/Access/Login", new()
        {
            Username = username,
            Password = password
        });

        if (httpResponse.IsSuccessStatusCode)
        {

            var JwtDTO = await httpResponse.Content.ReadFromJsonAsync<JwtDTO>();
#pragma warning disable CS8602 // Déréférencement d'une éventuelle référence null.
            httpClient.DefaultRequestHeaders.Authorization = new("bearer", JwtDTO.Token);
#pragma warning restore CS8602 // Déréférencement d'une éventuelle référence null.
        }
        else
        {
            Assert.Fail($"Impossible de se conecter avec {username}, {password}");
        }
    }

    public void Logout()
    {
        httpClient.DefaultRequestHeaders.Authorization = null;
    }

    /// <summary>
    /// Up The Test DataBase (Drop the scheme if already there to redo it)
    /// </summary>
    public void UpDatabase()
    {
        var stringConnection = _configuration.GetSection("DataBaseSettings").GetValue<string>("ConnectionString");
        IDbConnection con = new NpgsqlConnection(stringConnection);

        con.Open();
        string requeteSQL = File.ReadAllText("CreateDatabaseScript.sql");
        var commande = con.CreateCommand();
        commande.CommandText = requeteSQL;
        commande.ExecuteNonQuery();
        con.Dispose();
    }

#pragma warning disable CS1998 // Cette méthode async n'a pas d'opérateur 'await' et elle s'exécutera de façon synchrone
    public async Task ExecuteSqlAsync(string sql)
#pragma warning restore CS1998 // Cette méthode async n'a pas d'opérateur 'await' et elle s'exécutera de façon synchrone
    {
        var stringConnection = _configuration.GetSection("DataBaseSettings").GetValue<string>("ConnectionString");
        IDbConnection con = new NpgsqlConnection(stringConnection);

        con.Open();
        var commande = con.CreateCommand();
        commande.CommandText = sql;
        commande.ExecuteNonQuery();
        con.Dispose();
    }

}

