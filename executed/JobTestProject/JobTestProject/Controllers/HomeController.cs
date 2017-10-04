using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JobTestProject.Controllers
{
    //! Main controller, which return Views;
    public class HomeController : Controller
    {
        //! Return the main page;
        public ActionResult Index()
        {
            return View();
        }
        //! Consist description of my application;
        public ActionResult About()
        {
            ViewBag.Message = "This application is a test";

            return View();
        }

        
    }
}