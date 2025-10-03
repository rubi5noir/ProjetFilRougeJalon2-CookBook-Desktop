using APIProjetFilRouge.BLL.Interfaces;
using APIProjetFilRouge.BLL.Services;
using APIProjetFilRouge.DAL.UnitsOfWork;
using APIProjetFilRouge.Models.BussinessObjects;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace APIUnitTests.ServicesUnitTets
{
    public class CookBookServiceUnitTests
    {
        #region Avis

        #region GetAvisOfAllRecettesAsync

        [Fact]
        public void GetAvisOfAllRecettesAsync_ReturnsListAvis()
        {
            List<Avis> avis = new List<Avis>
            {
                new Avis { id_recette = 1, id_utilisateur = 1, commentaire = "Great recipe!", note = 5 },
                new Avis { id_recette = 1, id_utilisateur = 2, commentaire = "Good but a bit salty.", note = 4 },
                new Avis { id_recette = 2, id_utilisateur = 3, commentaire = "Didn't like it.", note = 2 }
            };

            // Arrange
            IUnitOfWork mockUnitOfWork = Mock.Of<IUnitOfWork>();
            Mock.Get(mockUnitOfWork)
                .Setup(uow =>
                uow.Avis.GetAllAvisAsync())
                .ReturnsAsync(avis);

            var sut = new CookBookService(mockUnitOfWork);

            var expectedResult = avis;

            // Act
            var result = sut.GetAvisOfAllRecettesAsync().Result;

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void GetAvisOfAllRecettesAsync_ReturnListEmpty()
        {
            List<Avis> avis = new List<Avis>();

            // Arrange
            IUnitOfWork mockUnitOfWork = Mock.Of<IUnitOfWork>();
            Mock.Get(mockUnitOfWork)
                .Setup(uow =>
                uow.Avis.GetAllAvisAsync())
                .ReturnsAsync(avis);

            var sut = new CookBookService(mockUnitOfWork);

            var expectedResult = avis;

            // Act
            var result = sut.GetAvisOfAllRecettesAsync().Result;

            // Assert
            Assert.Equal(expectedResult, result);
        }

        #endregion

        #region GetAvisOfRecetteAsync

        [Fact]
        public void GetAvisOfRecetteAsync_ReturnListAvis()
        {
            int id = 1;
            List<Avis> avis = new List<Avis>
            {
                new Avis { id_recette = 1, id_utilisateur = 1, commentaire = "Great recipe!", note = 5 },
                new Avis { id_recette = 1, id_utilisateur = 2, commentaire = "Good but a bit salty.", note = 4 },
                new Avis { id_recette = 1, id_utilisateur = 3, commentaire = "Didn't like it.", note = 2 }
            };

            // Arrange
            IUnitOfWork mockUnitOfWork = Mock.Of<IUnitOfWork>();
            Mock.Get(mockUnitOfWork)
                .Setup(uow =>
                uow.Avis.GetAvisByRecetteIdAsync(id))
                .ReturnsAsync(avis);

            var sut = new CookBookService(mockUnitOfWork);

            var expectedResult = avis;

            // Act
            var result = sut.GetAvisOfRecetteAsync(id).Result;

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void GetAvisOfRecetteAsync_ReturnListEmpty()
        {
            int id = 1;
            List<Avis> avis = new List<Avis>();

            // Arrange
            IUnitOfWork mockUnitOfWork = Mock.Of<IUnitOfWork>();
            Mock.Get(mockUnitOfWork)
                .Setup(uow =>
                uow.Avis.GetAvisByRecetteIdAsync(id))
                .ReturnsAsync(avis);

            var sut = new CookBookService(mockUnitOfWork);

            var expectedResult = avis;

            // Act
            var result = sut.GetAvisOfRecetteAsync(id).Result;

            // Assert
            Assert.Equal(expectedResult, result);
        }

        #endregion

        #region CreateAvisAsync

        [Theory]
        [InlineData(1)]
        [InlineData(0)]
        public void CreateAvisAsync_ReturnRowAffectedEqualRepositoryAffectedRow(int rowAffected)
        {
            Avis avis = new Avis()
            {
                id_recette = 1,
                id_utilisateur = 1,
                commentaire = "commentaire",
                note = 5
            };

            // Arrange
            IUnitOfWork mockUnitOfWork = Mock.Of<IUnitOfWork>();
            Mock.Get(mockUnitOfWork)
                .Setup(uow =>
                uow.Avis.CreateAvisAsync(avis))
                .ReturnsAsync(rowAffected);

            var sut = new CookBookService(mockUnitOfWork);

            var expectedResult = rowAffected;

            // Act
            var result = sut.CreateAvisAsync(avis).Result;

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(0)]
        [InlineData(2)]
        [InlineData(5)]
        [InlineData(10)]
        public void CreateAvisAsync_ReturnRowAffectedMaxOneRow(int rowAffected)
        {
            Avis avis = new Avis()
            {
                id_recette = 1,
                id_utilisateur = 1,
                commentaire = "commentaire",
                note = 5
            };

            // Arrange
            IUnitOfWork mockUnitOfWork = Mock.Of<IUnitOfWork>();
            Mock.Get(mockUnitOfWork)
                .Setup(uow =>
                uow.Avis.CreateAvisAsync(avis))
                .ReturnsAsync(rowAffected);

            var sut = new CookBookService(mockUnitOfWork);

            var expectedResult = 2;

            // Act
            var result = sut.CreateAvisAsync(avis).Result;

            // Assert
            Assert.True(result < expectedResult);
        }

        #endregion

        #region UpdateAvisAsync

        [Theory]
        [InlineData(1, true)]
        [InlineData(0, false)]
        [InlineData(2, false)]
        [InlineData(5, false)]
        [InlineData(10, false)]
        public void UpdateAvisAsync_ReturnResult(int rowAffected, bool expectedResult)
        {
            Avis avis = new Avis()
            {
                id_recette = 1,
                id_utilisateur = 1,
                commentaire = "commentaire",
                note = 5
            };

            // Arrange
            IUnitOfWork mockUnitOfWork = Mock.Of<IUnitOfWork>();
            Mock.Get(mockUnitOfWork)
                .Setup(uow =>
                uow.Avis.UpdateAvisAsync(avis))
                .ReturnsAsync(rowAffected);

            var sut = new CookBookService(mockUnitOfWork);

            // Act
            var result = sut.UpdateAvisAsync(avis).Result;

            // Assert
            Assert.Equal(expectedResult, result);
        }

        #endregion

        #region DeleteAvisAsync

        [Theory]
        [InlineData(1, true)]
        [InlineData(0, false)]
        [InlineData(2, false)]
        [InlineData(5, false)]
        [InlineData(10, false)]
        public void DeleteAvisAsync(int rowAffected, bool expectedResult)
        {
            // Arrange
            IUnitOfWork mockUnitOfWork = Mock.Of<IUnitOfWork>();
            Mock.Get(mockUnitOfWork)
                .Setup(uow =>
                uow.Avis.DeleteAvisAsync(It.IsAny<int>(), It.IsAny<int>()))
                .ReturnsAsync(rowAffected);

            var sut = new CookBookService(mockUnitOfWork);

            // Act
            var result = sut.DeleteAvisAsync(It.IsAny<int>(), It.IsAny<int>()).Result;

            // Assert
            Assert.Equal(expectedResult, result);
        }

        #endregion

        #endregion

        #region Categorie

        #region GetAllCategoriesAsync

        [Fact]
        public void GetAllCategoriesAsync_ReturnListCategories()
        {
            List<Categorie> categories = new List<Categorie>
            {
                new Categorie { id = 1, nom = "categorie 1"},
                new Categorie { id = 2, nom = "categorie 2" },
                new Categorie { id = 3, nom = "categorie 3" }
            };

            // Arrange
            IUnitOfWork mockUnitOfWork = Mock.Of<IUnitOfWork>();
            Mock.Get(mockUnitOfWork)
                .Setup(uow =>
                uow.Categorie.GetAllCategoriesAsync())
                .ReturnsAsync(categories);

            var sut = new CookBookService(mockUnitOfWork);

            var expectedResult = categories;

            // Act
            var result = sut.GetAllCategoriesAsync().Result;

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void GetAllCategoriesAsync_ReturnListEmpty()
        {
            List<Categorie> categories = new List<Categorie>();

            // Arrange
            IUnitOfWork mockUnitOfWork = Mock.Of<IUnitOfWork>();
            Mock.Get(mockUnitOfWork)
                .Setup(uow =>
                uow.Categorie.GetAllCategoriesAsync())
                .ReturnsAsync(categories);

            var sut = new CookBookService(mockUnitOfWork);

            var expectedResult = categories;

            // Act
            var result = sut.GetAllCategoriesAsync().Result;

            // Assert
            Assert.Equal(expectedResult, result);
        }

        #endregion

        #region GetCategoriesOfRecetteAsync

        [Fact]
        public void GetCategoriesOfRecetteAsync_ReturnListCategories()
        {
            int id = 1;

            List<Categorie> categories = new List<Categorie>
            {
                new Categorie { id = 1, nom = "categorie 1"},
                new Categorie { id = 2, nom = "categorie 2" },
                new Categorie { id = 3, nom = "categorie 3" }
            };

            // Arrange
            IUnitOfWork mockUnitOfWork = Mock.Of<IUnitOfWork>();
            Mock.Get(mockUnitOfWork)
                .Setup(uow =>
                uow.Categorie.GetCategoriesOfRecetteAsync(id))
                .ReturnsAsync(categories);

            var sut = new CookBookService(mockUnitOfWork);

            var expectedResult = categories;

            // Act
            var result = sut.GetCategoriesOfRecetteAsync(id).Result;

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void GetCategoriesOfRecetteAsync_ReturnListEmpty()
        {
            int id = 1;

            List<Categorie> categories = new List<Categorie>();

            // Arrange
            IUnitOfWork mockUnitOfWork = Mock.Of<IUnitOfWork>();
            Mock.Get(mockUnitOfWork)
                .Setup(uow =>
                uow.Categorie.GetCategoriesOfRecetteAsync(id))
                .ReturnsAsync(categories);

            var sut = new CookBookService(mockUnitOfWork);

            var expectedResult = categories;

            // Act
            var result = sut.GetCategoriesOfRecetteAsync(id).Result;

            // Assert
            Assert.Equal(expectedResult, result);
        }

        #endregion

        #region GetCategorieRelationshipsByIdAsync

        [Fact]
        public void GetCategorieRelationshipsByIdAsync_ReturnListInt()
        {
            int id = 1;

            List<int> recetteIds = new List<int>
            {
                1, 2, 3, 4, 9, 10, 11, 5, 14, 15, 16, 17, 18, 19
            };

            // Arrange
            IUnitOfWork mockUnitOfWork = Mock.Of<IUnitOfWork>();
            Mock.Get(mockUnitOfWork)
                .Setup(uow =>
                uow.Categorie.GetCategorieRelationshipsByIdAsync(id))
                .ReturnsAsync(recetteIds);

            var sut = new CookBookService(mockUnitOfWork);

            var expectedResult = recetteIds;

            // Act
            var result = sut.GetCategorieRelationshipsByIdAsync(id).Result;

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void GetCategorieRelationshipsByIdAsync_ReturnListEmpty()
        {
            int id = 1;

            List<int> recetteIds = new List<int>();

            // Arrange
            IUnitOfWork mockUnitOfWork = Mock.Of<IUnitOfWork>();
            Mock.Get(mockUnitOfWork)
                .Setup(uow =>
                uow.Categorie.GetCategorieRelationshipsByIdAsync(id))
                .ReturnsAsync(recetteIds);

            var sut = new CookBookService(mockUnitOfWork);

            var expectedResult = recetteIds;

            // Act
            var result = sut.GetCategorieRelationshipsByIdAsync(id).Result;

            // Assert
            Assert.Equal(expectedResult, result);
        }

        #endregion

        #region CreateCategorieAsync

        [Fact]
        public void CreateCategorieAsync_ReturnNewId()
        {
            int id = 1;
            string nom = "categorie";

            Categorie categorie = new Categorie
            {
                id = id,
                nom = nom
            };

            // Arrange
            IUnitOfWork mockUnitOfWork = Mock.Of<IUnitOfWork>();
            Mock.Get(mockUnitOfWork)
                .Setup(uow =>
                uow.Categorie.CreateCategorieAsync(nom))
                .ReturnsAsync(id);

            var sut = new CookBookService(mockUnitOfWork);

            var expectedResult = id;

            // Act
            var result = sut.CreateCategorieAsync(categorie).Result;

            // Assert
            Assert.Equal(expectedResult, result);
        }

        #endregion

        #region UpdateCategorieAsync

        [Theory]
        [InlineData(1, true)]
        [InlineData(0, false)]
        [InlineData(2, false)]
        [InlineData(5, false)]
        [InlineData(10, false)]
        public void UpdateCategorieAsync_ReturnResult(int rowAffected, bool expectedResult)
        {
            Categorie categorie = new Categorie()
            {
                id = 1,
                nom = "categorie"
            };

            // Arrange
            IUnitOfWork mockUnitOfWork = Mock.Of<IUnitOfWork>();
            Mock.Get(mockUnitOfWork)
                .Setup(uow =>
                uow.Categorie.UpdateCategorieAsync(categorie))
                .ReturnsAsync(rowAffected);

            var sut = new CookBookService(mockUnitOfWork);

            // Act
            var result = sut.UpdateCategorieAsync(categorie).Result;

            // Assert
            Assert.Equal(expectedResult, result);
        }

        #endregion

        #region DeleteCategorieAsync

        [Theory]
        [InlineData(1, true)]
        [InlineData(0, false)]
        [InlineData(2, false)]
        [InlineData(5, false)]
        [InlineData(10, false)]
        public void DeleteCategorieAsync_ReturnResult(int rowAffected, bool expectedResult)
        {
            int id = 1;

            // Arrange
            IUnitOfWork mockUnitOfWork = Mock.Of<IUnitOfWork>();
            Mock.Get(mockUnitOfWork)
                .Setup(uow =>
                uow.Categorie.DeleteCategorieAsync(id))
                .ReturnsAsync(rowAffected);

            var sut = new CookBookService(mockUnitOfWork);

            // Act
            var result = sut.DeleteCategorieAsync(id).Result;

            // Assert
            Assert.Equal(expectedResult, result);
        }

        #endregion

        #region AddCategorieToRecetteAsync

        [Theory]
        [InlineData(1, true)]
        [InlineData(0, false)]
        [InlineData(2, false)]
        [InlineData(5, false)]
        [InlineData(10, false)]
        public void AddCategorieToRecetteAsync_ReturnResult(int rowAffected, bool expectedResult)
        {
            int id = 1;

            Categorie categorie = new Categorie()
            {
                id = 1,
                nom = "categorie"
            };

            // Arrange
            IUnitOfWork mockUnitOfWork = Mock.Of<IUnitOfWork>();
            Mock.Get(mockUnitOfWork)
                .Setup(uow =>
                uow.Categorie.AddCategorieToRecetteAsync(id, categorie))
                .ReturnsAsync(rowAffected);

            var sut = new CookBookService(mockUnitOfWork);

            // Act
            var result = sut.AddCategorieToRecetteAsync(id, categorie).Result;

            // Assert
            Assert.Equal(expectedResult, result);
        }

        #endregion

        #region RemoveCategorieFromRecetteAsync

        [Theory]
        [InlineData(1, true)]
        [InlineData(0, false)]
        [InlineData(2, false)]
        [InlineData(5, false)]
        [InlineData(10, false)]
        public void RemoveCategorieFromRecetteAsync_ReturnResult(int rowAffected, bool expectedResult)
        {
            int id = 1;

            Categorie categorie = new Categorie()
            {
                id = 1,
                nom = "categorie"
            };

            // Arrange
            IUnitOfWork mockUnitOfWork = Mock.Of<IUnitOfWork>();
            Mock.Get(mockUnitOfWork)
                .Setup(uow =>
                uow.Categorie.RemoveCategorieFromRecetteAsync(id, categorie))
                .ReturnsAsync(rowAffected);

            var sut = new CookBookService(mockUnitOfWork);

            // Act
            var result = sut.RemoveCategorieFromRecetteAsync(id, categorie).Result;

            // Assert
            Assert.Equal(expectedResult, result);
        }

        #endregion

        #endregion

        #region Compte

        #region GetAllComptesAsync

        [Fact]
        public void GetAllComptesAsync_ReturnListComptes()
        {
            List<Compte> comptes = new List<Compte>
            {
                new Compte{id = 1,identifiant = "jdupont",nom = "Dupont",prenom = "Jean",email = "jean.dupont@example.com",password = "password123",admin = false},
                new Compte{id = 2,identifiant = "mdupuis",nom = "Dupuis",prenom = "Marie",email = "marie.dupuis@example.com",password = "azerty456",admin = true},
                new Compte{id = 3,identifiant = "tbernard",nom = "Bernard",prenom = "Thomas",email = "thomas.bernard@example.com",password = "secure789",admin = false}
            };

            // Arrange
            IUnitOfWork mockUnitOfWork = Mock.Of<IUnitOfWork>();
            Mock.Get(mockUnitOfWork)
                .Setup(uow =>
                uow.Compte.GetAllComptesAsync())
                .ReturnsAsync(comptes);

            var sut = new CookBookService(mockUnitOfWork);

            var expectedResult = comptes;

            // Act
            var result = sut.GetAllComptesAsync().Result;

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void GetAllComptesAsync_ReturnListEmpty()
        {
            List<Compte> comptes = new List<Compte>();

            // Arrange
            IUnitOfWork mockUnitOfWork = Mock.Of<IUnitOfWork>();
            Mock.Get(mockUnitOfWork)
                .Setup(uow =>
                uow.Compte.GetAllComptesAsync())
                .ReturnsAsync(comptes);

            var sut = new CookBookService(mockUnitOfWork);

            var expectedResult = comptes;

            // Act
            var result = sut.GetAllComptesAsync().Result;

            // Assert
            Assert.Equal(expectedResult, result);
        }

        #endregion

        #region GetCompteByIdAsync

        [Fact]
        public void GetCompteByIdAsync_ReturnCompte()
        {
            int id = 1;

            Compte compte = new Compte { id = 1, identifiant = "jdupont", nom = "Dupont", prenom = "Jean", email = "jean.dupont@example.com", password = "password123", admin = false };

            // Arrange
            IUnitOfWork mockUnitOfWork = Mock.Of<IUnitOfWork>();
            Mock.Get(mockUnitOfWork)
                .Setup(uow =>
                uow.Compte.GetCompteByIdAsync(id))
                .ReturnsAsync(compte);

            var sut = new CookBookService(mockUnitOfWork);

            var expectedResult = compte;

            // Act
            var result = sut.GetCompteByIdAsync(id).Result;

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void GetCompteByIdAsync_ReturnNull()
        {
            int id = 1;

            Compte compte = null;

            // Arrange
            IUnitOfWork mockUnitOfWork = Mock.Of<IUnitOfWork>();
            Mock.Get(mockUnitOfWork)
                .Setup(uow =>
                uow.Compte.GetCompteByIdAsync(id))
                .ReturnsAsync(compte);

            var sut = new CookBookService(mockUnitOfWork);

            Compte expectedResult = null;

            // Act
            var result = sut.GetCompteByIdAsync(id).Result;

            // Assert
            Assert.Equal(expectedResult, result);
        }

        #endregion

        #region CreateCompteAsync

        [Fact]
        public void CreateCompteAsync_ReturnNewId()
        {
            int id = 1;

            Compte compte = new Compte { id = 1, identifiant = "jdupont", nom = "Dupont", prenom = "Jean", email = "jean.dupont@example.com", password = "password123", admin = false };

            // Arrange
            IUnitOfWork mockUnitOfWork = Mock.Of<IUnitOfWork>();
            Mock.Get(mockUnitOfWork)
                .Setup(uow =>
                uow.Compte.CreateCompteAsync(compte))
                .ReturnsAsync(id);

            var sut = new CookBookService(mockUnitOfWork);

            var expectedResult = id;

            // Act
            var result = sut.CreateCompteAsync(compte).Result;

            // Assert
            Assert.Equal(expectedResult, result);
        }

        #endregion

        #region UpdateCompteAsync

        [Theory]
        [InlineData(1, true)]
        [InlineData(0, false)]
        [InlineData(2, false)]
        [InlineData(5, false)]
        [InlineData(10, false)]
        public void UpdateCompteAsync_ReturnResult(int rowAffected, bool expectedResult)
        {
            int id = 1;

            Compte compte = new Compte { id = 1, identifiant = "jdupont", nom = "Dupont", prenom = "Jean", email = "jean.dupont@example.com", password = "password123", admin = false };

            // Arrange
            IUnitOfWork mockUnitOfWork = Mock.Of<IUnitOfWork>();
            Mock.Get(mockUnitOfWork)
                .Setup(uow =>
                uow.Compte.UpdateCompteAsync(compte))
                .ReturnsAsync(rowAffected);

            var sut = new CookBookService(mockUnitOfWork);

            // Act
            var result = sut.UpdateCompteAsync(compte).Result;

            // Assert
            Assert.Equal(expectedResult, result);
        }

        #endregion

        #region DeleteCompteAsync

        [Theory]
        [InlineData(1, true)]
        [InlineData(0, false)]
        [InlineData(2, false)]
        [InlineData(5, false)]
        [InlineData(10, false)]
        public void DeleteCompteAsync_ReturnResult(int rowAffected, bool expectedResult)
        {
            int id = 1;

            // Arrange
            IUnitOfWork mockUnitOfWork = Mock.Of<IUnitOfWork>();
            Mock.Get(mockUnitOfWork)
                .Setup(uow =>
                uow.Compte.DeleteCompteAsync(id))
                .ReturnsAsync(rowAffected);

            var sut = new CookBookService(mockUnitOfWork);

            // Act
            var result = sut.DeleteCompteAsync(id).Result;

            // Assert
            Assert.Equal(expectedResult, result);
        }

        #endregion

        #endregion

        #region Etape

        #region GetAllEtapesAsync

        [Fact]
        public void GetAllEtapesAsync_ReturnListEtapes()
        {
            List<Etape> etapes = new List<Etape>
            {
                new Etape { numero = 1, id_recette = 1, texte = "Préparer les légumes" },
                new Etape { numero = 2, id_recette = 1, texte = "Faire cuire la viande" }
            };

            // Arrange
            IUnitOfWork mockUnitOfWork = Mock.Of<IUnitOfWork>();
            Mock.Get(mockUnitOfWork)
                .Setup(uow => uow.Etape.GetAllEtapesAsync())
                .ReturnsAsync(etapes);

            var sut = new CookBookService(mockUnitOfWork);

            var expectedResult = etapes;

            // Act
            var result = sut.GetAllEtapesAsync().Result;

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void GetAllEtapesAsync_ReturnListEmpty()
        {
            List<Etape> etapes = new List<Etape>();

            // Arrange
            IUnitOfWork mockUnitOfWork = Mock.Of<IUnitOfWork>();
            Mock.Get(mockUnitOfWork)
                .Setup(uow => uow.Etape.GetAllEtapesAsync())
                .ReturnsAsync(etapes);

            var sut = new CookBookService(mockUnitOfWork);

            var expectedResult = etapes;

            // Act
            var result = sut.GetAllEtapesAsync().Result;

            // Assert
            Assert.Equal(expectedResult, result);
        }

        #endregion

        #region GetEtapesOfRecetteAsync

        [Fact]
        public void GetEtapesOfRecetteAsync_ReturnListEtapes()
        {
            int id = 1;
            List<Etape> etapes = new List<Etape>
            {
                new Etape { numero = 1, id_recette = 1, texte = "Préparer les légumes" },
                new Etape { numero = 2, id_recette = 1, texte = "Faire cuire la viande" }
            };

            // Arrange
            IUnitOfWork mockUnitOfWork = Mock.Of<IUnitOfWork>();
            Mock.Get(mockUnitOfWork)
                .Setup(uow => uow.Etape.GetEtapesOfRecetteAsync(id))
                .ReturnsAsync(etapes);

            var sut = new CookBookService(mockUnitOfWork);

            var expectedResult = etapes;

            // Act
            var result = sut.GetEtapesOfRecetteAsync(id).Result;

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void GetEtapesOfRecetteAsync_ReturnListEmpty()
        {
            int id = 1;
            List<Etape> etapes = new List<Etape>();

            // Arrange
            IUnitOfWork mockUnitOfWork = Mock.Of<IUnitOfWork>();
            Mock.Get(mockUnitOfWork)
                .Setup(uow => uow.Etape.GetEtapesOfRecetteAsync(id))
                .ReturnsAsync(etapes);

            var sut = new CookBookService(mockUnitOfWork);

            var expectedResult = etapes;

            // Act
            var result = sut.GetEtapesOfRecetteAsync(id).Result;

            // Assert
            Assert.Equal(expectedResult, result);
        }

        #endregion

        #region CreateEtapeAsync

        [Fact]
        public void CreateEtapeAsync_ReturnNewId()
        {
            int id = 1;
            Etape etape = new Etape { numero = 1, id_recette = 1, texte = "Préparer les légumes" };

            // Arrange
            IUnitOfWork mockUnitOfWork = Mock.Of<IUnitOfWork>();
            Mock.Get(mockUnitOfWork)
                .Setup(uow => uow.Etape.CreateEtapeAsync(etape))
                .ReturnsAsync(id);

            var sut = new CookBookService(mockUnitOfWork);

            var expectedResult = id;

            // Act
            var result = sut.CreateEtapeAsync(etape).Result;

            // Assert
            Assert.Equal(expectedResult, result);
        }

        #endregion

        #region UpdateEtapeAsync

        [Theory]
        [InlineData(1, true)]
        [InlineData(0, false)]
        [InlineData(2, false)]
        [InlineData(5, false)]
        [InlineData(10, false)]
        public void UpdateEtapeAsync_ReturnResult(int rowAffected, bool expectedResult)
        {
            int id = 1;
            Etape etape = new Etape { numero = 1, id_recette = 1, texte = "Préparer les légumes" };

            // Arrange
            IUnitOfWork mockUnitOfWork = Mock.Of<IUnitOfWork>();
            Mock.Get(mockUnitOfWork)
                .Setup(uow => uow.Etape.UpdateEtapeAsync(id, etape))
                .ReturnsAsync(rowAffected);

            var sut = new CookBookService(mockUnitOfWork);

            // Act
            var result = sut.UpdateEtapeAsync(id, etape).Result;

            // Assert
            Assert.Equal(expectedResult, result);
        }

        #endregion

        #region DeleteEtapeAsync

        [Theory]
        [InlineData(1, true)]
        [InlineData(0, false)]
        [InlineData(2, false)]
        [InlineData(5, false)]
        [InlineData(10, false)]
        public void DeleteEtapeAsync_ReturnResult(int rowAffected, bool expectedResult)
        {
            int id = 1;
            int numero = 1;

            // Arrange
            IUnitOfWork mockUnitOfWork = Mock.Of<IUnitOfWork>();
            Mock.Get(mockUnitOfWork)
                .Setup(uow => uow.Etape.DeleteEtapeAsync(id, numero))
                .ReturnsAsync(rowAffected);

            var sut = new CookBookService(mockUnitOfWork);

            // Act
            var result = sut.DeleteEtapeAsync(id, numero).Result;

            // Assert
            Assert.Equal(expectedResult, result);
        }

        #endregion

        #endregion

        #region Ingredient

        #region GetAllIngredientsAsync

        [Fact]
        public void GetAllIngredientsAsync_ReturnListIngredients()
        {
            List<Ingredient> ingredients = new List<Ingredient>
            {
                new Ingredient { id = 1, nom = "Tomate" },
                new Ingredient { id = 2, nom = "Pomme de terre" },
                new Ingredient { id = 3, nom = "Poulet" }
            };

            // Arrange
            IUnitOfWork mockUnitOfWork = Mock.Of<IUnitOfWork>();
            Mock.Get(mockUnitOfWork)
                .Setup(uow => uow.Ingredient.GetAllIngredientsAsync())
                .ReturnsAsync(ingredients);

            var sut = new CookBookService(mockUnitOfWork);

            var expectedResult = ingredients;

            // Act
            var result = sut.GetAllIngredientsAsync().Result;

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void GetAllIngredientsAsync_ReturnListEmpty()
        {
            List<Ingredient> ingredients = new List<Ingredient>();

            // Arrange
            IUnitOfWork mockUnitOfWork = Mock.Of<IUnitOfWork>();
            Mock.Get(mockUnitOfWork)
                .Setup(uow => uow.Ingredient.GetAllIngredientsAsync())
                .ReturnsAsync(ingredients);

            var sut = new CookBookService(mockUnitOfWork);

            var expectedResult = ingredients;

            // Act
            var result = sut.GetAllIngredientsAsync().Result;

            // Assert
            Assert.Equal(expectedResult, result);
        }

        #endregion

        #region GetIngredientsWithQuantitiesOfRecetteAsync

        [Fact]
        public void GetIngredientsWithQuantitiesOfRecetteAsync_ReturnListIngredients()
        {
            int recetteId = 1;
            List<Ingredient> ingredients = new List<Ingredient>
            {
                new Ingredient { id = 1, nom = "Tomate", quantite = "2 pièces" },
                new Ingredient { id = 2, nom = "Oignon", quantite = "1 pièce" }
            };

            // Arrange
            IUnitOfWork mockUnitOfWork = Mock.Of<IUnitOfWork>();
            Mock.Get(mockUnitOfWork)
                .Setup(uow => uow.Ingredient.GetIngredientsWithQuantitiesOfRecetteAsync(recetteId))
                .ReturnsAsync(ingredients);

            var sut = new CookBookService(mockUnitOfWork);

            var expectedResult = ingredients;

            // Act
            var result = sut.GetIngredientsWithQuantitiesOfRecetteAsync(recetteId).Result;

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void GetIngredientsWithQuantitiesOfRecetteAsync_ReturnListEmpty()
        {
            int recetteId = 1;
            List<Ingredient> ingredients = new List<Ingredient>();

            // Arrange
            IUnitOfWork mockUnitOfWork = Mock.Of<IUnitOfWork>();
            Mock.Get(mockUnitOfWork)
                .Setup(uow => uow.Ingredient.GetIngredientsWithQuantitiesOfRecetteAsync(recetteId))
                .ReturnsAsync(ingredients);

            var sut = new CookBookService(mockUnitOfWork);

            var expectedResult = ingredients;

            // Act
            var result = sut.GetIngredientsWithQuantitiesOfRecetteAsync(recetteId).Result;

            // Assert
            Assert.Equal(expectedResult, result);
        }

        #endregion

        #region CreateIngredientAsync

        [Fact]
        public void CreateIngredientAsync_ReturnNewId()
        {
            int id = 1;
            Ingredient ingredient = new Ingredient { id = id, nom = "Carotte" };

            // Arrange
            IUnitOfWork mockUnitOfWork = Mock.Of<IUnitOfWork>();
            Mock.Get(mockUnitOfWork)
                .Setup(uow => uow.Ingredient.CreateIngredientAsync(ingredient))
                .ReturnsAsync(id);

            var sut = new CookBookService(mockUnitOfWork);

            var expectedResult = id;

            // Act
            var result = sut.CreateIngredientAsync(ingredient).Result;

            // Assert
            Assert.Equal(expectedResult, result);
        }

        #endregion

        #region UpdateIngredientAsync

        [Theory]
        [InlineData(1, true)]
        [InlineData(0, false)]
        [InlineData(2, false)]
        [InlineData(5, false)]
        [InlineData(10, false)]
        public void UpdateIngredientAsync_ReturnResult(int rowAffected, bool expectedResult)
        {
            Ingredient ingredient = new Ingredient { id = 1, nom = "Courgette" };

            // Arrange
            IUnitOfWork mockUnitOfWork = Mock.Of<IUnitOfWork>();
            Mock.Get(mockUnitOfWork)
                .Setup(uow => uow.Ingredient.UpdateIngredientAsync(ingredient))
                .ReturnsAsync(rowAffected);

            var sut = new CookBookService(mockUnitOfWork);

            // Act
            var result = sut.UpdateIngredientAsync(ingredient).Result;

            // Assert
            Assert.Equal(expectedResult, result);
        }

        #endregion

        #region DeleteIngredientAsync

        [Theory]
        [InlineData(1, true)]
        [InlineData(0, false)]
        [InlineData(2, false)]
        [InlineData(5, false)]
        [InlineData(10, false)]
        public void DeleteIngredientAsync_ReturnResult(int rowAffected, bool expectedResult)
        {
            int id = 1;

            // Arrange
            IUnitOfWork mockUnitOfWork = Mock.Of<IUnitOfWork>();
            Mock.Get(mockUnitOfWork)
                .Setup(uow => uow.Ingredient.DeleteIngredientAsync(id))
                .ReturnsAsync(rowAffected);

            var sut = new CookBookService(mockUnitOfWork);

            // Act
            var result = sut.DeleteIngredientAsync(id).Result;

            // Assert
            Assert.Equal(expectedResult, result);
        }

        #endregion

        #region AddIngredientToRecetteAsync

        [Theory]
        [InlineData(1, true)]
        [InlineData(0, false)]
        [InlineData(2, false)]
        [InlineData(5, false)]
        [InlineData(10, false)]
        public void AddIngredientToRecetteAsync_ReturnResult(int rowAffected, bool expectedResult)
        {
            int recetteId = 1;
            Ingredient ingredient = new Ingredient { id = 1, nom = "Tomate", quantite = "2 pièces" };

            // Arrange
            IUnitOfWork mockUnitOfWork = Mock.Of<IUnitOfWork>();
            Mock.Get(mockUnitOfWork)
                .Setup(uow => uow.Ingredient.AddIngredientToRecetteAsync(recetteId, ingredient))
                .ReturnsAsync(rowAffected);

            var sut = new CookBookService(mockUnitOfWork);

            // Act
            var result = sut.AddIngredientToRecetteAsync(recetteId, ingredient).Result;

            // Assert
            Assert.Equal(expectedResult, result);
        }

        #endregion

        #region RemoveIngredientFromRecetteAsync

        [Theory]
        [InlineData(1, true)]
        [InlineData(0, false)]
        [InlineData(2, false)]
        [InlineData(5, false)]
        [InlineData(10, false)]
        public void RemoveIngredientFromRecetteAsync_ReturnResult(int rowAffected, bool expectedResult)
        {
            int recetteId = 1;
            Ingredient ingredient = new Ingredient { id = 1, nom = "Tomate", quantite = "2 pièces" };

            // Arrange
            IUnitOfWork mockUnitOfWork = Mock.Of<IUnitOfWork>();
            Mock.Get(mockUnitOfWork)
                .Setup(uow => uow.Ingredient.RemoveIngredientFromRecetteAsync(recetteId, ingredient))
                .ReturnsAsync(rowAffected);

            var sut = new CookBookService(mockUnitOfWork);

            // Act
            var result = sut.RemoveIngredientFromRecetteAsync(recetteId, ingredient).Result;

            // Assert
            Assert.Equal(expectedResult, result);
        }

        #endregion

        #endregion

        #region Recette

        #region GetAllRecettesAsync

        [Fact]
        public void GetAllRecettesAsync_ReturnListRecettes()
        {
            List<Recette> recettes = new List<Recette>
            {
                new Recette { id = 1, nom = "Tarte aux pommes", description = "Délicieuse tarte" },
                new Recette { id = 2, nom = "Poulet rôti", description = "Classique familial" }
            };

            // Arrange
            IUnitOfWork mockUnitOfWork = Mock.Of<IUnitOfWork>();
            Mock.Get(mockUnitOfWork)
                .Setup(uow => uow.Recette.GetAllRecettesAsync())
                .ReturnsAsync(recettes);

            var sut = new CookBookService(mockUnitOfWork);

            var expectedResult = recettes;

            // Act
            var result = sut.GetAllRecettesAsync().Result;

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void GetAllRecettesAsync_ReturnListEmpty()
        {
            List<Recette> recettes = new List<Recette>();

            // Arrange
            IUnitOfWork mockUnitOfWork = Mock.Of<IUnitOfWork>();
            Mock.Get(mockUnitOfWork)
                .Setup(uow => uow.Recette.GetAllRecettesAsync())
                .ReturnsAsync(recettes);

            var sut = new CookBookService(mockUnitOfWork);

            var expectedResult = recettes;

            // Act
            var result = sut.GetAllRecettesAsync().Result;

            // Assert
            Assert.Equal(expectedResult, result);
        }

        #endregion

        #region GetRecetteByIdAsync

        [Fact]
        public void GetRecetteByIdAsync_ReturnRecette()
        {
            int id = 1;
            Recette recette = new Recette { id = 1, nom = "Soupe à l'oignon", description = "Recette traditionnelle" };

            // Arrange
            IUnitOfWork mockUnitOfWork = Mock.Of<IUnitOfWork>();
            Mock.Get(mockUnitOfWork)
                .Setup(uow => uow.Recette.GetRecetteByIdAsync(id))
                .ReturnsAsync(recette);

            var sut = new CookBookService(mockUnitOfWork);

            var expectedResult = recette;

            // Act
            var result = sut.GetRecetteByIdAsync(id).Result;

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void GetRecetteByIdAsync_ReturnNull()
        {
            int id = 1;
            Recette recette = null;

            // Arrange
            IUnitOfWork mockUnitOfWork = Mock.Of<IUnitOfWork>();
            Mock.Get(mockUnitOfWork)
                .Setup(uow => uow.Recette.GetRecetteByIdAsync(id))
                .ReturnsAsync(recette);

            var sut = new CookBookService(mockUnitOfWork);

            Recette expectedResult = null;

            // Act
            var result = sut.GetRecetteByIdAsync(id).Result;

            // Assert
            Assert.Equal(expectedResult, result);
        }

        #endregion

        #region CreateRecetteAsync

        [Fact]
        public void CreateRecetteAsync_ReturnNewId()
        {
            int id = 1;
            Recette recette = new Recette { id = id, nom = "Salade César", description = "Simple et rapide" };
            List<Ingredient> ingredients = new List<Ingredient>();
            List<Etape> etapes = new List<Etape>();
            List<Categorie> categories = new List<Categorie>();

            // Arrange
            IUnitOfWork mockUnitOfWork = Mock.Of<IUnitOfWork>();
            Mock.Get(mockUnitOfWork)
                .Setup(uow => uow.Recette.CreateRecetteAsync(recette))
                .ReturnsAsync(id);

            var sut = new CookBookService(mockUnitOfWork);

            var expectedResult = id;

            // Act
            var result = sut.CreateRecetteAsync(recette, categories, etapes, ingredients).Result;

            // Assert
            Assert.Equal(expectedResult, result);
        }

        #endregion

        #region UpdateRecetteAsync

        [Theory]
        [InlineData(1, true)]
        [InlineData(0, false)]
        [InlineData(2, false)]
        [InlineData(5, false)]
        [InlineData(10, false)]
        public void UpdateRecetteAsync_ReturnResult(int rowAffected, bool expectedResult)
        {
            Recette recette = new Recette { id = 1, nom = "Lasagnes", description = "Recette italienne" };
            List<Ingredient> ingredients = new List<Ingredient>();
            List<Etape> etapes = new List<Etape>();
            List<Categorie> categories = new List<Categorie>();

            // Arrange
            IUnitOfWork mockUnitOfWork = Mock.Of<IUnitOfWork>();
            Mock.Get(mockUnitOfWork)
                .Setup(uow => uow.Recette.UpdateRecetteAsync(recette))
                .ReturnsAsync(rowAffected);

            var sut = new CookBookService(mockUnitOfWork);

            // Act
            var result = sut.UpdateRecetteAsync(recette, categories, etapes, ingredients).Result;

            // Assert
            Assert.Equal(expectedResult, result);
        }

        #endregion

        #region DeleteRecetteAsync

        [Theory]
        [InlineData(1, true)]
        [InlineData(0, false)]
        [InlineData(2, false)]
        [InlineData(5, false)]
        [InlineData(10, false)]
        public void DeleteRecetteAsync_ReturnResult(int rowAffected, bool expectedResult)
        {
            int id = 1;

            // Arrange
            IUnitOfWork mockUnitOfWork = Mock.Of<IUnitOfWork>();

            // stub pour éviter null dans les foreach
            Mock.Get(mockUnitOfWork)
                .Setup(uow => uow.Categorie.GetCategoriesOfRecetteAsync(id))
                .ReturnsAsync(new List<Categorie>());

            Mock.Get(mockUnitOfWork)
                .Setup(uow => uow.Etape.GetEtapesOfRecetteAsync(id))
                .ReturnsAsync(new List<Etape>());

            Mock.Get(mockUnitOfWork)
                .Setup(uow => uow.Ingredient.GetIngredientsWithQuantitiesOfRecetteAsync(id))
                .ReturnsAsync(new List<Ingredient>());

            // stub principal qu’on teste
            Mock.Get(mockUnitOfWork)
                .Setup(uow => uow.Recette.DeleteRecetteAsync(id))
                .ReturnsAsync(rowAffected);

            var sut = new CookBookService(mockUnitOfWork);

            // Act
            var result = sut.DeleteRecetteAsync(id).Result;

            // Assert
            Assert.Equal(expectedResult, result);
        }

        #endregion

        #endregion
    }

}
