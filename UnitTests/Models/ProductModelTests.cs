using Microsoft.VisualStudio.TestTools.UnitTesting;
using HWUT.Models;
using System;

namespace UnitTests
{
    [TestClass]
    public class ProductModelTests
    {
        [TestMethod]
        public void ProductModel_Constructor_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ProductModel_Get_Date_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(DateTime.UtcNow.ToShortDateString(), result.Date.ToShortDateString());
        }

        [TestMethod]
        public void ProductModel_Set_Date_Default_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Date = new DateTime(2020,5,28);

            // Assert
            Assert.AreEqual("5/28/2020", result.Date.ToShortDateString());
        }

        [TestMethod]
        public void ProductModel_Get_Id_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(null, result.Id);
        }

        [TestMethod]
        public void ProductModel_Set_Id_Default_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Id = "testbot123";

            // Assert
            Assert.AreEqual("testbot123", result.Id);
        }

        [TestMethod]
        public void ProductModel_Set_Id_EmptyString_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Id = "";

            // Assert
            Assert.AreEqual("", result.Id);
        }

        [TestMethod]
        public void ProductModel_Get_Maker_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(null, result.Maker);
        }

        [TestMethod]
        public void ProductModel_Set_Maker_Default_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Maker = "God Hand";

            // Assert
            Assert.AreEqual("God Hand", result.Maker);
        }

        [TestMethod]
        public void ProductModel_Set_Maker_EmptyString_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Maker = "";

            // Assert
            Assert.AreEqual("", result.Maker);
        }

        [TestMethod]
        public void ProductModel_Get_Image_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(null, result.Image);
        }

        [TestMethod]
        public void ProductModel_Set_Image_Default_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Image = "~/img/masterpiece.jpg";

            // Assert
            Assert.AreEqual("~/img/masterpiece.jpg", result.Image);
        }

        [TestMethod]
        public void ProductModel_Set_Image_EmptyString_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Image = "";

            // Assert
            Assert.AreEqual("", result.Image);
        }

        [TestMethod]
        public void ProductModel_Get_Url_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(null, result.Url);
        }

        [TestMethod]
        public void ProductModel_Set_Url_Default_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Url = "www.seattleu.edu";

            // Assert
            Assert.AreEqual("www.seattleu.edu", result.Url);
        }

        [TestMethod]
        public void ProductModel_Set_Url_EmptyString_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Url = "";

            // Assert
            Assert.AreEqual("", result.Url);
        }

        [TestMethod]
        public void ProductModel_Get_Title_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(null, result.Title);
        }

        [TestMethod]
        public void ProductModel_Set_Title_Default_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Title = "Seattle U, a pretty Campus";

            // Assert
            Assert.AreEqual("Seattle U, a pretty Campus", result.Title);
        }

        [TestMethod]
        public void ProductModel_Set_Title_EmptyString_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Title = "";

            // Assert
            Assert.AreEqual("", result.Title);
        }

        [TestMethod]
        public void ProductModel_Get_Description_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(null, result.Description);
        }

        [TestMethod]
        public void ProductModel_Set_Description_Default_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Description = "Wow Unit testing is so fun!";

            // Assert
            Assert.AreEqual("Wow Unit testing is so fun!", result.Description);
        }

        [TestMethod]
        public void ProductModel_Set_Description_EmptyString_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Description = "";

            // Assert
            Assert.AreEqual("", result.Description);
        }

        [TestMethod]
        public void ProductModel_Get_Sequence_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(null, result.Sequence);
        }

        [TestMethod]
        public void ProductModel_Set_Sequence_Default_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Sequence = "TourStart2";

            // Assert
            Assert.AreEqual("TourStart2", result.Sequence);
        }

        [TestMethod]
        public void ProductModel_Set_Sequence_EmptyString_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Sequence = "";

            // Assert
            Assert.AreEqual("", result.Sequence);
        }

        [TestMethod]
        public void ProductModel_Get_Email_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual("Unknown", result.Email);
        }

        [TestMethod]
        public void ProductModel_Set_Email_Default_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Email = "jungbok@wanna.go.out";

            // Assert
            Assert.AreEqual("jungbok@wanna.go.out", result.Email);
        }

        [TestMethod]
        public void ProductModel_Set_Email_EmptyString_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Email = "";

            // Assert
            Assert.AreEqual("", result.Email);
        }

        [TestMethod]
        public void ProductModel_Get_Logistics_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual("", result.Logistics);
        }

        [TestMethod]
        public void ProductModel_Set_Logistics_Default_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Logistics = "I will pickup";

            // Assert
            Assert.AreEqual("I will pickup", result.Logistics);
        }

        [TestMethod]
        public void ProductModel_Set_Logistics_EmptyString_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Logistics = "";

            // Assert
            Assert.AreEqual("", result.Logistics);
        }

        [TestMethod]
        public void ProductModel_Get_Ratings_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            for(int i = 0; i < result.Ratings.Length; i++) {
                Assert.AreEqual(5, result.Ratings[i]);
            }
            
        }

        [TestMethod]
        public void ProductModel_Set_Ratings_AfterIntialization_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Ratings = new int[] { 10 };

            // Assert
            for (int i = 0; i < result.Ratings.Length; i++)
            {
                Assert.AreEqual(10, result.Ratings[i]);
            }
        }

        [TestMethod]
        public void ProductModel_Set_Ratings_ChangeElement_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Ratings[0] = 7;

            // Assert
            for (int i = 0; i < result.Ratings.Length; i++)
            {
                if (i == 0)
                {
                    Assert.AreEqual(7, result.Ratings[i]);
                }
                else 
                {
                    Assert.AreEqual(5, result.Ratings[i]);
                }
            }
        }


        [TestMethod]
        public void ProductModel_Set_ToString_Default_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();
            var result2 = new ProductModel();

            // Act
            result.Date = new DateTime(2020, 05, 28);
            result2.Date = new DateTime(2020, 05, 28);

            // Assert
            Assert.AreEqual(result.ToString(), result2.ToString());
        }

        [TestMethod]
        public void ProductModel_Set_ToString_AfterIntialization_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();
            var result2 = new ProductModel();

            // Act
            result.Date = new DateTime(2020, 05, 28);
            result2.Date = new DateTime(2020, 05, 28);
            result.Url = "www.seattleu.edu";
            result2.Url = "www.seattleu.edu";
            result.Maker = "God Hand";
            result2.Maker = "God Hand";

            // Assert
            Assert.AreEqual(result.ToString(), result2.ToString());
        }
        

        [TestMethod]
        public void ProductModel_Set_ToString_NotEqual_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();
            var result2 = new ProductModel();

            // Act
            result.Date = new DateTime(2020, 05, 28);
            result2.Date = new DateTime(2020, 05, 28);
            result.Ratings[0] = 7;

            // Assert
            Assert.AreNotEqual(result.ToString(), result2.ToString());
        }

        [TestMethod]
        public void ProductModel_Set_AverageRating_Default_Should_Pass()
        {
            // Arrange


            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(5, result.AverageRating());
        }

        [TestMethod]
        public void ProductModel_Set_AverageRating_RatingIsNull_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Ratings = null;

            // Assert
            Assert.AreEqual(0, result.AverageRating());
        }

        [TestMethod]
        public void ProductModel_Set_AverageRating_RatingIsEmpty_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Ratings = new int[] { };

            // Assert
            Assert.AreEqual(0, result.AverageRating());
        }

        [TestMethod]
        public void ProductModel_Set_AverageRating_TotalIsZero_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            for (int i = 0; i < result.Ratings.Length; i++)
            {
                result.Ratings[i] = 0;
            }

            // Assert
            Assert.AreEqual(0, result.AverageRating());
        }

        [TestMethod]
        public void ProductModel_Set_AverageRating_AfterInitialization_Should_Pass()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Ratings = new int[] { 7 };

            // Assert
            Assert.AreEqual(7, result.AverageRating());
        }

    }

}
