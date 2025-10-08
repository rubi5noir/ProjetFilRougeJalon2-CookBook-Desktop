using APIProjetFilRouge.Models.DataTransfertObjects.In;
using APIProjetFilRouge.Models.DataTransfertObjects.Out;
using APITestIntegration.Fixture;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

[assembly: CollectionBehavior(DisableTestParallelization = true)]

namespace APITestIntegration.Fixture;
public abstract class IntegrationTest : IClassFixture<APIWebApplicationFactory>
{
    public HttpClient httpClient { get; set; }
    private IConfiguration _configuration { get; set; }
    public IntegrationTest(APIWebApplicationFactory webApi)
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
            httpClient.DefaultRequestHeaders.Authorization = new("bearer", JwtDTO.Token);
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

    public async Task ExecuteSqlAsync(string sql)
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

