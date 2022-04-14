using GroupMVCProject;
using GroupMVCProject.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace GroupMVCProject.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
             // Arrange
             HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

         [TestMethod]
         public void Register()
         {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Register() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
         }

         [TestMethod]
         public void Course()
         {
            // Arrange
             HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Course() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
         }

         [TestMethod]
         public void Modules()
         {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Modules() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
         }

         [TestMethod]
         public void Student()
         {
            // Arrange
            HomeController controller = new HomeController();

             // Act
             ViewResult result = controller.Student() as ViewResult;

             // Assert
             Assert.IsNotNull(result);
         }

         [TestMethod]
         public void CourseNameID1()
         {
            // Arrange
             HomeController controller = new HomeController();

             // Act
             ViewResult result = controller.Course() as ViewResult;

             // Assert
             Assert.AreEqual("Computer Science", result.ViewBag.Message);
         }

         [TestMethod]
         public void CourseNameID2()
         {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Course() as ViewResult;

            // Assert
            Assert.AreEqual("Software Engineering", result.ViewBag.Message);
         }

         [TestMethod]
         public void CourseNameID3()
         {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Course() as ViewResult;

            // Assert
            Assert.AreEqual("Cyber Security", result.ViewBag.Message);
         }

         [TestMethod]
         public void Username()
         {
            // Arrange
            HomeController controller = new HomeController();

            controller.Username = "Aisha";
            // controller.Password = "1";

            // Act
            ViewResult result = controller.Register() as ViewResult;

            Assert.AreEqual("Registration successful!", result.ViewBag.SubTitle);
         }

         [TestMethod]
         public void Password()
         {
            // Arrange
            HomeController controller = new HomeController();

            controller.Password = "1234";
            // controller.Password = "1";

            // Act
            ViewResult result = controller.Register() as ViewResult;

            Assert.AreEqual("Registration successful!", result.ViewBag.SubTitle);
         }
    }
}