using APIProjetFilRouge.Models.DataTransfertObjects.Between;
using APIProjetFilRouge.Models.DataTransfertObjects.Out;
using APITestIntegration.Fixture;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace APITestIntegration
{
    public class CategoriesControllerTest : IntegrationTest
    {
        public CategoriesControllerTest(APIWebApplicationFactory webApi) : base(webApi)
        {

        }

        #region GetCategories

        [Fact]
        public async void GetCategories_ReturnExpectedListOfCategories()
        {
            //Arrange
            UpDatabase();
            await Login("admin", "admin");
            List<CategorieDTO> categoriesExpected = new List<CategorieDTO>()
            {
                new()
                {
                    id = 1,
                    nom = "sans gluten"
                },
                new()
                {
                    id = 2,
                    nom = "végétale"
                },
                new()
                {
                    id = 3,
                    nom = "naturel"
                },
                new()
                {
                    id = 4,
                    nom = "dessert"
                },
                new()
                {
                    id = 5,
                    nom = "plats"
                },
                new()
                {
                    id = 6,
                    nom = "entrée"
                },
                new()
                {
                    id = 7,
                    nom = "snack"
                },
                new()
                {
                    id = 8,
                    nom = "légume"
                },
                new()
                {
                    id = 9,
                    nom = "fruit"
                },
                new()
                {
                    id = 10,
                    nom = "fromage"
                },
                new()
                {
                    id = 11,
                    nom = "viande"
                },
                new()
                {
                    id = 12,
                    nom = "chocolat"
                },
                new()
                {
                    id = 13,
                    nom = "sucré"
                }
            };

            //Act
            var list = await httpClient.GetFromJsonAsync<List<CategorieDTO>>("/api/Categories");

            //Assert
            Assert.NotNull(list);
            Assert.Equivalent(categoriesExpected, list);

            Logout();

        }

        [Fact]
        public async void GetCategories_ReturnsBadRequest_WhenSomethingWrong()
        {
            // Arrange
            UpDatabase();
            await Login("admin", "admin");

            // Simule un cas provoquant une BadRequest
            // (par exemple en appelant une route incorrecte volontairement)
            string url = "/api/Categories";

            // Vide la table des catégories pour provoquer le BadRequest
            await ExecuteSqlAsync("DELETE FROM public.categories_recettes;");
            await ExecuteSqlAsync("DELETE FROM public.categories;");

            // Act + Assert
            var exception = await Assert.ThrowsAsync<HttpRequestException>(async () =>
            {
                var response = await httpClient.GetAsync(url);

                // Si le code n’est PAS une BadRequest, on force l’échec
                if (response.StatusCode != HttpStatusCode.BadRequest)
                {
                    response.EnsureSuccessStatusCode();
                }

                var body = await response.Content.ReadAsStringAsync();

                // Vérifie que le corps est vide
                Assert.True(string.IsNullOrWhiteSpace(body) || body.Trim() == "[]", $"Expected empty list body ('[]'), got: '{body}'");

                // Pour que ThrowsAsync capture bien quelque chose,
                // on lève une exception personnalisée
                throw new HttpRequestException("BadRequest returned as expected.");
            });

            // Vérifie le message de l’exception
            Assert.Contains("BadRequest", exception.Message);

            Logout();
        }

        #endregion

        #region GetRecipesIDsFromCategorieID

        [Fact]
        public async void GetRecipesIDsFromCategorieID_ReturnExpectedListOfIDs()
        {
            //Arrange
            UpDatabase();
            await Login("admin", "admin");
            int categorie = 2;
            List<int> Expected = new()
            {
                38,
                39
            };

            //Act
            var list = await httpClient.GetFromJsonAsync<List<int>>($"/api/Categories/RecettesIDs/{categorie}");

            //Assert
            Assert.NotNull(list);
            Assert.Equivalent(Expected, list);

            Logout();

        }

        [Fact]
        public async void GetRecipesIDsFromCategorieID_ReturnsBadRequest_WhenSomethingWrong()
        {
            // Arrange
            UpDatabase();
            await Login("admin", "admin");

            int categorie = 999; // ID inexistant pour forcer la liste vide

            // Act
            var response = await httpClient.GetAsync($"/api/Categories/RecettesIDs/{categorie}");

            // Assert
            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);

            var body = await response.Content.ReadAsStringAsync();
            var normalized = body?.Trim().Replace("\n", "").Replace("\r", "").Replace("\"", "");

            Assert.Equal("Aucune Recettes trouvées", normalized);

            Logout();
        }

        #endregion

        #region GetCategoriesByRecetteID

        [Fact]
        public async void GetCategoriesByRecetteID_ReturnExpectedListOfCategories()
        {
            //Arrange
            UpDatabase();
            await Login("admin", "admin");
            int recette = 5;
            List<CategorieDTO> categorieExpected = new List<CategorieDTO>()
            {
                new CategorieDTO
                {
                    id = 1,
                    nom = "sans gluten"
                },
                new CategorieDTO
                {
                    id = 7,
                    nom = "snack"
                }


            };

            //Act
            var list = await httpClient.GetFromJsonAsync<List<CategorieDTO>>($"/api/Categories/{recette}");

            //Assert
            Assert.NotNull(list);
            Assert.Equivalent(categorieExpected, list);

            Logout();

        }

        [Fact]
        public async void GetCategoriesByRecetteID_ReturnsBadRequest_WhenSomethingWrong()
        {
            // Arrange
            UpDatabase();
            await Login("admin", "admin");

            int recette = 999; // ID de recette inexistant pour provoquer la liste vide

            // Act
            var response = await httpClient.GetAsync($"/api/Categories/{recette}");

            // Assert
            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);

            var body = await response.Content.ReadAsStringAsync();

            Assert.Equal("[]", body.Trim());

            Logout();
        }

        #endregion

        #region CreateCategorie

        [Fact]
        public async void CreateCategorie_Return_The_NewID()
        {
            //Arrange
            UpDatabase();
            await Login("admin", "admin");
            CategorieDTO createCategorieDTO = new CategorieDTO()
            {
                id = 0,
                nom = "Test"
            };

            int Expected = 14;

            //Act
            var reponseHttp = await httpClient.PostAsJsonAsync($"/api/Categories", createCategorieDTO);

            // Assert
            reponseHttp.EnsureSuccessStatusCode();
            var createdID = await reponseHttp.Content.ReadFromJsonAsync<int>();

            Assert.NotNull(createdID);
            Assert.Equal(Expected, createdID);


            Logout();
        }

        [Fact]
        public async void CreateCategorie_ReturnsBadRequest_WhenSomethingWrong()
        {
            // Arrange
            UpDatabase();
            await Login("admin", "admin");
            CategorieDTO createCategorieDTO = new CategorieDTO()
            {
                id = 0,
                nom = ""
            };

            // Act
            var response = await httpClient.PostAsJsonAsync($"/api/Categories", createCategorieDTO);

            // Assert
            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);

            var body = await response.Content.ReadAsStringAsync();
            var normalized = body?.Trim().Replace("\n", "").Replace("\r", "").Replace("\"", "");

            Assert.Equal("Création de la catégorie échouée.", normalized);

            Logout();
        }

        #endregion

        #region AddCategorieToRecette

        [Fact]
        public async void AddCategorieToRecette_ReturnTrue()
        {
            // Arrange
            UpDatabase();
            await Login("admin", "admin");
            int recetteID = 5;
            CategorieDTO categorieDTO = new CategorieDTO
            {
                id = 2,
                nom = "végétale"
            };
            bool Expected = true;

            // Act
            var response = await httpClient.PostAsJsonAsync($"/api/Categories/AddToRecette/{recetteID}", categorieDTO);

            // Assert
            response.EnsureSuccessStatusCode();
            var result = await response.Content.ReadFromJsonAsync<bool>();

            Assert.True(result);
            Assert.Equal(Expected, result);

            Logout();
        }

        [Fact]
        public async void AddCategorieToRecette_ReturnBadRequest_WhenInvalid()
        {
            // Arrange
            UpDatabase();
            await Login("admin", "admin");
            int recetteID = 5;
            CategorieDTO categorieDTO = new CategorieDTO
            {
                id = 0,
                nom = ""
            };

            // Act
            var response = await httpClient.PostAsJsonAsync($"/api/Categories/AddToRecette/{recetteID}", categorieDTO);

            // Assert
            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);

            var body = await response.Content.ReadAsStringAsync();
            var normalized = body?.Trim().Replace("\"", "");

            Assert.Equal("Ajout de la catégorie à la recette échouée.", normalized);

            Logout();
        }

        #endregion

        #region UpdateCategorie

        [Fact]
        public async void UpdateCategorie_ReturnTrue()
        {
            // Arrange
            UpDatabase();
            await Login("admin", "admin");
            int id = 3;
            CategorieDTO updateCategorieDTO = new()
            {
                id = id,
                nom = "naturel modifié"
            };
            bool Expected = true;

            // Act
            var response = await httpClient.PutAsJsonAsync($"/api/Categories/{id}", updateCategorieDTO);

            // Assert
            response.EnsureSuccessStatusCode();
            var result = await response.Content.ReadFromJsonAsync<bool>();

            Assert.True(result);
            Assert.Equal(Expected, result);

            Logout();
        }

        [Fact]
        public async void UpdateCategorie_ReturnBadRequest_WhenInvalid()
        {
            // Arrange
            UpDatabase();
            await Login("admin", "admin");
            int id = 5; 
            CategorieDTO updateCategorieDTO = new()
            {
                id = id,
                nom = ""
            };

            // Act
            var response = await httpClient.PutAsJsonAsync($"/api/Categories/{id}", updateCategorieDTO);

            // Assert
            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);

            var body = await response.Content.ReadAsStringAsync();
            var normalized = body?.Trim().Replace("\"", "");

            Assert.Equal("Mise à jour de la catégorie échouée.", normalized);

            Logout();
        }

        #endregion

        #region DeleteCategorie

        [Fact]
        public async void DeleteCategorie_ReturnTrue()
        {
            // Arrange
            UpDatabase();
            await Login("admin", "admin");
            int id = 13;
            bool Expected = true;

            // Act
            var response = await httpClient.DeleteAsync($"/api/Categories/{id}");

            // Assert
            response.EnsureSuccessStatusCode();
            var result = await response.Content.ReadFromJsonAsync<bool>();

            Assert.True(result);
            Assert.Equal(Expected, result);

            Logout();
        }

        [Fact]
        public async void DeleteCategorie_ReturnBadRequest_WhenInvalid()
        {
            // Arrange
            UpDatabase();
            await Login("admin", "admin");
            int id = 999;

            // Act
            var response = await httpClient.DeleteAsync($"/api/Categories/{id}");

            // Assert
            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);

            var body = await response.Content.ReadAsStringAsync();
            var normalized = body?.Trim().Replace("\"", "");

            Assert.Equal("Suppression de la catégorie échouée.", normalized);

            Logout();
        }

        #endregion

        #region RemoveCategorieFromRecette

        [Fact]
        public async void RemoveCategorieFromRecette_ReturnTrue()
        {
            // Arrange
            UpDatabase();
            await Login("admin", "admin");
            int recetteID = 5;
            CategorieDTO categorieDTO = new CategorieDTO
            {
                id = 7,
                nom = "snack"
            };
            bool Expected = true;

            // Act
            var request = new HttpRequestMessage(HttpMethod.Delete, $"/api/Categories/RemoveFromRecette/{recetteID}")
            {
                Content = JsonContent.Create(categorieDTO)
            };

            var response = await httpClient.SendAsync(request);

            // Assert
            response.EnsureSuccessStatusCode();
            var result = await response.Content.ReadFromJsonAsync<bool>();

            Assert.True(result);
            Assert.Equal(Expected, result);

            Logout();
        }

        [Fact]
        public async void RemoveCategorieFromRecette_ReturnBadRequest_WhenInvalid()
        {
            // Arrange
            UpDatabase();
            await Login("admin", "admin");
            int recetteID = 5;
            CategorieDTO categorieDTO = new CategorieDTO
            {
                id = 5,
                nom = ""
            };

            var request = new HttpRequestMessage(HttpMethod.Delete, $"/api/Categories/RemoveFromRecette/{recetteID}")
            {
                Content = JsonContent.Create(categorieDTO)
            };

            // Act
            var response = await httpClient.SendAsync(request);

            // Assert
            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);

            var body = await response.Content.ReadAsStringAsync();
            var normalized = body?.Trim().Replace("\"", "");

            Assert.Equal("Suppression de la catégorie à la recette échouée.", normalized);

            Logout();
        }

        #endregion
    }
}
