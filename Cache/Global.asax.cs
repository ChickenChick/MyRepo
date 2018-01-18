using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Cache.App_Start;

namespace Cache
{
    public class MvcApplication : System.Web.HttpApplication
    {

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            SimpleInjectorConfig.Config();

        }
        public override string GetVaryByCustomString(HttpContext context, string custom)
        {
            if (custom == "my-prm")
            {
                return context.Request.Browser.Browser;
            }
            return base.GetVaryByCustomString(context, custom);
        }
    }
}
