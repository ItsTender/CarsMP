using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace CarsMP
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            Application["counter"] = 0; // Start the Login Counter!

        }

        void Session_Start(object sender, EventArgs e) {

            // Guest User!
            Session["uName"] = "Guest";
            Session["userFName"] = "Guest";
            Session["admin"] = "no";

        }

        void Session_End(object sender, EventArgs e) {

            // Guest User!
            Session["uName"] = "Guest";
            Session["userFName"] = "Guest";
            Session["admin"] = "no";

        }

    }
}