using APIProjetFilRouge.BLL.Interfaces;
using APIProjetFilRouge.Controllers;
using APIProjetFilRouge.Models.BussinessObjects;
using APIProjetFilRouge.Models.DataTransfertObjects.Between;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIUnitTests.APIUnitTests
{
    public class CategoriesControllerUnitTests
    {
        #region GetAllCategories

        [Fact]
        public void GetAllCategories_ReturnsOkResult_WithListOfCategories()
        {
            List<Categorie> categories = new List<Categorie>
            {
                new Categorie { id = 1, nom = "Category1" },
                new Categorie { id = 2, nom = "Category2" }
            };

            // Arrange
            ICookBookService mockService = Mock.Of<ICookBookService>();
            Mock.Get(mockService)
                .Setup(service => service.GetAllCategoriesAsync())
                .ReturnsAsync(categories);

            var sut = new CategoriesController(mockService);

            var expectedResponse = new OkObjectResult(categories.Select(c => new CategorieDTO
            {
                id = c.id,
                nom = c.nom
            }).ToList());

            // Act
            var result = sut.GetAllCategories().Result as ObjectResult;

            // Assert
            Assert.Equivalent(expectedResponse, result);
        }

        [Fact]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "xUnit1031:Do not use blocking task operations in test method", Justification = "<En attente>")]
        public void GetAllCategories_ReturnsBadRequestResult_WithListOfCategoriesEmpty()
        {
            List<Categorie> categories = new List<Categorie>();

            // Arrange
            ICookBookService mockService = Mock.Of<ICookBookService>();
            Mock.Get(mockService)
                .Setup(service => service.GetAllCategoriesAsync())
                .ReturnsAsync(categories);

            var sut = new CategoriesController(mockService);

            var expectedResponse = new BadRequestObjectResult(new List<CategorieDTO>());

            // Act
            var result = sut.GetAllCategories().Result as ObjectResult;

            // Assert
            Assert.Equivalent(expectedResponse, result);
        }

        #endregion

        #region GetRecipesIDsFromCategorieID

        [Fact]
        public void GetRecipesIDsFromCategorieID_ReturnsOkResult_WithListOfRecetteIDs()
        {
            int categorieId = 1;
            List<int> recetteIDs = new List<int> { 1, 2, 3 };

            // Arrange
            ICookBookService mockService = Mock.Of<ICookBookService>();
            Mock.Get(mockService)
                .Setup(service => service.GetCategorieRelationshipsByIdAsync(categorieId))
                .ReturnsAsync(recetteIDs);

            var sut = new CategoriesController(mockService);

            var expectedResponse = new OkObjectResult(recetteIDs);

            // Act
            var result = sut.GetRecipesIDsFromCategorieID(categorieId).Result as ObjectResult;
           
            // Assert
            Assert.Equivalent(expectedResponse, result);
        }

        [Fact]
        public void GetRecipesIDsFromCategorieID_ReturnsBadRequestResult_WithEmptyList()
        {
            int categorieId = 1;
            List<int> recetteIDs = new List<int>();

            // Arrange
            ICookBookService mockService = Mock.Of<ICookBookService>();
            Mock.Get(mockService)
                .Setup(service => service.GetCategorieRelationshipsByIdAsync(categorieId))
                .ReturnsAsync(recetteIDs);

            var sut = new CategoriesController(mockService);

            var expectedResponse = new BadRequestObjectResult("Aucune Recettes trouvées");
            
            // Act
            var result = sut.GetRecipesIDsFromCategorieID(categorieId).Result as ObjectResult;
            
            // Assert
            Assert.Equivalent(expectedResponse, result);
        }

        #endregion

        #region GetCategorieByRecetteID

        [Fact]
        public void GetCategoriesByRecetteID_ReturnsOkResult_WithListOfCategories()
        {
            int recetteId = 1;
            List<Categorie> categories = new List<Categorie>
            {
                new Categorie { id = 1, nom = "Category1" },
                new Categorie { id = 2, nom = "Category2" }
            };

            // Arrange
            ICookBookService mockService = Mock.Of<ICookBookService>();
            Mock.Get(mockService)
                .Setup(service => service.GetCategoriesOfRecetteAsync(recetteId))
                .ReturnsAsync(categories);

            var sut = new CategoriesController(mockService);

            var expectedResponse = new OkObjectResult(categories.Select(c => new CategorieDTO
            {
                id = c.id,
                nom = c.nom
            }).ToList());
            
            // Act
            var result = sut.GetCategoriesByRecetteID(recetteId).Result as ObjectResult;
            
            // Assert
            Assert.Equivalent(expectedResponse, result);
        }

        [Fact]
        public void GetCategoriesByRecetteID_ReturnsBadRequestResult_WithEmptyList()
        {
            int recetteId = 1;
            List<Categorie> categories = new List<Categorie>();

            // Arrange
            ICookBookService mockService = Mock.Of<ICookBookService>();
            Mock.Get(mockService)
                .Setup(service => service.GetCategoriesOfRecetteAsync(recetteId))
                .ReturnsAsync(categories);

            var sut = new CategoriesController(mockService);

            var expectedResponse = new BadRequestObjectResult(new List<CategorieDTO>());
            
            // Act
            var result = sut.GetCategoriesByRecetteID(recetteId).Result as ObjectResult;
            
            // Assert
            Assert.Equivalent(expectedResponse, result);
        }

        #endregion

        #region CreateCategorie

        [Fact]
        public void CreateCategorie_ReturnsCreatedResult_WithNewCategoryId()
        {
            int newCategoryId = 1;
            IValidator<CategorieDTO> validator = new ValidatorCategorieDTO();
            CategorieDTO categorieDTO = new CategorieDTO { id = 0, nom = "NewCategory" };

            // Arrange
            ICookBookService mockService = Mock.Of<ICookBookService>();
            Mock.Get(mockService)
                .Setup(service => service.CreateCategorieAsync(It.IsAny<Categorie>()))
                .ReturnsAsync(newCategoryId);

            var sut = new CategoriesController(mockService);

            var expectedResponse = new ObjectResult(newCategoryId) { StatusCode = 201 };

            // Act
            var result = sut.CreateCategorie(validator, categorieDTO).Result as ObjectResult;

            // Assert
            Assert.Equivalent(expectedResponse, result);
        }

        [Fact]
#pragma warning disable CS1998 // Cette méthode async n'a pas d'opérateur 'await' et elle s'exécutera de façon synchrone
        public async Task CreateCategorie_ReturnsBadRequest()
#pragma warning restore CS1998 // Cette méthode async n'a pas d'opérateur 'await' et elle s'exécutera de façon synchrone
        {
            int newCategoryId = 0;
            IValidator<CategorieDTO> validator = new ValidatorCategorieDTO();
            CategorieDTO categorieDTO = new CategorieDTO { id = 0, nom = "NewCategory" };

            // Arrange
            ICookBookService mockService = Mock.Of<ICookBookService>();
            Mock.Get(mockService)
                .Setup(service => service.CreateCategorieAsync(It.IsAny<Categorie>()))
                .ReturnsAsync(newCategoryId);

            var sut = new CategoriesController(mockService);

            var expectedResponse = new BadRequestObjectResult("Création de la catégorie échouée.");

            // Act 
            var result = sut.CreateCategorie(validator, categorieDTO);

            // Assert
            Assert.Equivalent(expectedResponse, result.Result);
        }

        #endregion

        #region AddCategorieToRecette

        [Fact]
        public async Task AddCategorieToRecette_ReturnsOkResult_WithTrue()
        {
            int recetteId = 1;
            IValidator<CategorieDTO> validator = new ValidatorCategorieDTO();
            CategorieDTO categorieDTO = new CategorieDTO
            {
                id = 1,
                nom = "Category1"
            };

            Categorie categorie = new Categorie
            {
                id = 1,
                nom = "Category1"
            };

            // Arrange
            ICookBookService mockService = Mock.Of<ICookBookService>();
            Mock.Get(mockService)
                .Setup(service => service.AddCategorieToRecetteAsync(recetteId, categorie))
                .ReturnsAsync(true);

            var sut = new CategoriesController(mockService);

            var expectedResponse = new OkObjectResult(true);

            // Act
            var result = await sut.AddCategorieToRecette(validator, recetteId, categorieDTO) as ObjectResult;
            
            // Assert
            Assert.Equivalent(expectedResponse, result);
        }

        [Fact]
        public async Task AddCategorieToRecette_ReturnsBadRequest()
        {
            int recetteId = 1;
            IValidator<CategorieDTO> validator = new ValidatorCategorieDTO();
            CategorieDTO categorieDTO = new CategorieDTO
            {
                id = 1,
                nom = "Category1"
            };

            Categorie categorie = new Categorie
            {
                id = 1,
                nom = "Category1"
            };

            // Arrange
            ICookBookService mockService = Mock.Of<ICookBookService>();
            Mock.Get(mockService)
                .Setup(service => service.AddCategorieToRecetteAsync(recetteId, categorie))
                .ReturnsAsync(false);

            var sut = new CategoriesController(mockService);

            var expectedResponse = new BadRequestObjectResult("Ajout de la catégorie à la recette échouée.");
            
            // Act
            var result = await sut.AddCategorieToRecette(validator, recetteId, categorieDTO) as ObjectResult;
            
            // Assert
            Assert.Equivalent(expectedResponse, result);
        }

        #endregion

        #region UpdateCategorie

        [Fact]
        public async Task UpdateCategorie_ReturnsOkResult_WithTrue()
        {
            int newCategoryId = 1;
            IValidator<CategorieDTO> validator = new ValidatorCategorieDTO();
            CategorieDTO categorieDTO = new CategorieDTO
            { id = newCategoryId, nom = "UpdatedCategory" };

            Categorie categorie = new Categorie
            { id = newCategoryId, nom = "UpdatedCategory" };

            // Arrange
            ICookBookService mockService = Mock.Of<ICookBookService>();
            Mock.Get(mockService)
                .Setup(service => service.UpdateCategorieAsync(categorie))
                .ReturnsAsync(true);

            var sut = new CategoriesController(mockService);

            var expectedResponse = new OkObjectResult(true);

            // Act
            var result = await sut.UpdateCategorie(validator, newCategoryId, categorieDTO) as ObjectResult;

            // Assert
            Assert.Equivalent(expectedResponse, result);
        }

        [Fact]
#pragma warning disable CS1998 // Cette méthode async n'a pas d'opérateur 'await' et elle s'exécutera de façon synchrone
        public async Task UpdateCategorie_ReturnsBadRequest()
#pragma warning restore CS1998 // Cette méthode async n'a pas d'opérateur 'await' et elle s'exécutera de façon synchrone
        {
            int newCategoryId = 1;
            IValidator<CategorieDTO> validator = new ValidatorCategorieDTO();
            CategorieDTO categorieDTO = new CategorieDTO
            { id = newCategoryId, nom = "UpdatedCategory" };

            Categorie categorie = new Categorie
            { id = newCategoryId, nom = "UpdatedCategory" };

            // Arrange
            ICookBookService mockService = Mock.Of<ICookBookService>();
            Mock.Get(mockService)
                .Setup(service => service.UpdateCategorieAsync(categorie))
                .ReturnsAsync(false);

            var sut = new CategoriesController(mockService);

            var expectedResponse = new BadRequestObjectResult("Mise à jour de la catégorie échouée.");

            // Act
            var result = sut.UpdateCategorie(validator, newCategoryId, categorieDTO);

            // Assert
            Assert.Equivalent(expectedResponse, result.Result);
        }

        #endregion

        #region DeleteCategorie

        [Fact]
        public async Task DeleteCategorie_ReturnsOkResult_WithTrue()
        {
            int CategoryId = 1;

            // Arrange
            ICookBookService mockService = Mock.Of<ICookBookService>();
            Mock.Get(mockService)
                .Setup(service => service.DeleteCategorieAsync(CategoryId))
                .ReturnsAsync(true);

            var sut = new CategoriesController(mockService);

            var expectedResponse = new OkObjectResult(true);

            // Act
            var result = await sut.DeleteCategorie(CategoryId) as ObjectResult;

            // Assert
            Assert.Equivalent(expectedResponse, result);
        }

        [Fact]
        public async Task DeleteCategorie_ReturnsBadRequest()
        {
            int CategoryId = 1;

            // Arrange
            ICookBookService mockService = Mock.Of<ICookBookService>();
            Mock.Get(mockService)
                .Setup(service => service.DeleteCategorieAsync(CategoryId))
                .ReturnsAsync(false);

            var sut = new CategoriesController(mockService);

            var expectedResponse = new BadRequestObjectResult("Suppression de la catégorie échouée.");

            // Act
            var result = await sut.DeleteCategorie(CategoryId) as ObjectResult;

            // Assert
            Assert.Equivalent(expectedResponse, result);
        }

        #endregion

        #region RemoveCategorieFromRecette

        [Fact]
        public async Task RemoveCategorieFromRecette_ReturnsOkResult_WithTrue()
        {
            int recetteId = 1;
            IValidator<CategorieDTO> validator = new ValidatorCategorieDTO();
            CategorieDTO categorieDTO = new CategorieDTO
            {
                id = 1,
                nom = "Category1"
            };

            Categorie categorie = new Categorie
            {
                id = 1,
                nom = "Category1"
            };

            // Arrange
            ICookBookService mockService = Mock.Of<ICookBookService>();
            Mock.Get(mockService)
                .Setup(service => service.RemoveCategorieFromRecetteAsync(recetteId, categorie))
                .ReturnsAsync(true);

            var sut = new CategoriesController(mockService);

            var expectedResponse = new OkObjectResult(true);

            // Act
            var result = await sut.RemoveCategorieFromRecette(validator, recetteId, categorieDTO) as ObjectResult;
            
            // Assert
            Assert.Equivalent(expectedResponse, result);
        }

        [Fact]
        public async Task RemoveCategorieFromRecette_ReturnsBadRequest()
        {
            int recetteId = 1;
            IValidator<CategorieDTO> validator = new ValidatorCategorieDTO();
            CategorieDTO categorieDTO = new CategorieDTO
            {
                id = 1,
                nom = "Category1"
            };

            Categorie categorie = new Categorie
            {
                id = 1,
                nom = "Category1"
            };

            // Arrange
            ICookBookService mockService = Mock.Of<ICookBookService>();
            Mock.Get(mockService)
                .Setup(service => service.RemoveCategorieFromRecetteAsync(recetteId, categorie))
                .ReturnsAsync(false);

            var sut = new CategoriesController(mockService);

            var expectedResponse = new BadRequestObjectResult("Suppression de la catégorie à la recette échouée.");
            
            // Act
            var result = await sut.RemoveCategorieFromRecette(validator, recetteId, categorieDTO) as ObjectResult;
            
            // Assert
            Assert.Equivalent(expectedResponse, result);
        }

        #endregion
    }
}
