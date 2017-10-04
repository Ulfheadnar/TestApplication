using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JobTestProject.Controllers;
using System.Web.Mvc;

namespace JobTestProject.Tests
{

    //! Test class of HomeController;
    [TestClass]
    public class HomeControllerTest
    {
        //! Action which checks ViewResult of action Index();
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
        //! Action which checks ViewResult of action About();
        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

       
    }
}
