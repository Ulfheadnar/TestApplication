using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JobTestProject.Controllers;
using System.Web.Mvc;

namespace JobTestProject.Tests
{
    //! Test class of MyAcuaintancesController;
    [TestClass]
    public class MyAcuaintancesControllerTest
    {
        //! Action which checks ViewResult of action Create();
        [TestMethod]
        public void CreateViewNotFound()
        {
            MyAcuaintancesController controller = new MyAcuaintancesController();

            ViewResult result = controller.Create() as ViewResult;

            Assert.IsNotNull(result);
        }

        



       
    }
}
