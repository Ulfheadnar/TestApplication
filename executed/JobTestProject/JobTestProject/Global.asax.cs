using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Data.Entity;
using JobTestProject.Data;
using JobTestProject.Models;

namespace JobTestProject
{
    //! Class which is enter to programe;
    public class MvcApplication : System.Web.HttpApplication
    {
        //! Action which configure areas, filters, routes and bundles, which included in App_Start;
        protected void Application_Start()
        {
            // Database.SetInitializer(new InitializatorDb());
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
