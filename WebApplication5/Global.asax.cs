using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace WebApplication5
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        // Malcom Myers - Creating an event Handler for each request 
        void Application_AcquireRequestState(object sender, EventArgs e)
        {
            if (HttpContext.Current.Session != null)
            {
                if (HttpContext.Current.User != null &&

                    HttpContext.Current.User.Identity.IsAuthenticated)
                {
                    string usr = HttpContext.Current.User.Identity.Name;

                    Session["CurrentUsername"] = usr;
                }
                else
                {
                    Session["CurrentUsername"] = null;
                }
            }
        }
    }
}