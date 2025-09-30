using APIProjetFilRouge.BLL.Interfaces;
using APIProjetFilRouge.Controllers;
using APIProjetFilRouge.Models.BussinessObjects;
using APIProjetFilRouge.Models.DataTransfertObjects.Between;
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
        public void GetAllCategories_ReturnsOKResult_WithListOfCategoriesEmpty()
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

            var expectedResponse = new OkObjectResult(new List<CategorieDTO>());

            // Act
            var result = sut.GetAllCategories().Result as ObjectResult;

            // Assert
            Assert.Equivalent(expectedResponse, result);
        }

        #endregion

        #region CreateCategorie

        [Fact]
        public void CreateCategorie_ReturnsCreatedResult_WithNewCategoryId()
        {
            int newCategoryId = 1;
            CategorieDTO categorieDTO = new CategorieDTO { id = 0, nom = "NewCategory" };

            // Arrange
            ICookBookService mockService = Mock.Of<ICookBookService>();
            Mock.Get(mockService)
                .Setup(service => service.CreateCategorieAsync(It.IsAny<Categorie>()))
                .ReturnsAsync(newCategoryId);

            var sut = new CategoriesController(mockService);

            var expectedResponse = new ObjectResult(newCategoryId) { StatusCode = 201 };

            // Act
            var result = sut.CreateCategorie(categorieDTO).Result as ObjectResult;

            // Assert
            Assert.Equivalent(expectedResponse, result);
        }

        [Fact]
        public async void CreateCategorie_ReturnsBadRequest()
        {
            int newCategoryId = 0;
            CategorieDTO categorieDTO = new CategorieDTO { id = 0, nom = "NewCategory" };

            // Arrange
            ICookBookService mockService = Mock.Of<ICookBookService>();
            Mock.Get(mockService)
                .Setup(service => service.CreateCategorieAsync(It.IsAny<Categorie>()))
                .ReturnsAsync(newCategoryId);

            var sut = new CategoriesController(mockService);

            var expectedResponse = new BadRequestObjectResult("Création de la catégorie échouée.");

            // Act 
            var result = sut.CreateCategorie(categorieDTO);

            // Assert
            Assert.Equivalent(expectedResponse, result.Result);
        }

        #endregion

        #region UpdateCategorie

        [Fact]
        public async void UpdateCategorie_ReturnsOkResult_WithTrue()
        {
            int newCategoryId = 1;

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
            var result = await sut.UpdateCategorie(newCategoryId, categorieDTO) as ObjectResult;

            // Assert
            Assert.Equivalent(expectedResponse, result);
        }

        [Fact]
        public async void UpdateCategorie_ReturnsBadRequest()
        {
            int newCategoryId = 1;

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
            var result = sut.UpdateCategorie(newCategoryId, categorieDTO);

            // Assert
            Assert.Equivalent(expectedResponse, result.Result);
        }

        #endregion

        #region DeleteCategorie

        [Fact]
        public async void DeleteCategorie_ReturnsOkResult_WithTrue()
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
        public async void DeleteCategorie_ReturnsBadRequest()
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
    }
}
