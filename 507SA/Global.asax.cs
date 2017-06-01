using _507SA.App_Start;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace _507SA
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
			Bootstrapper.Initialize();
			BundleConfig.RegisterBundles(BundleTable.Bundles);
			AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
