using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Cache.Contracts.Contracts;
using System.Reflection;
using System.Web.Mvc;

namespace Cache.App_Start
{
    public class SimpleInjectorConfig
    {
        public static void Config()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();


            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());

            var compositionModules = new ICompositionModule[]
            {
                new Cache.DAL.CompositionModule(),
                new Cache.Business.CompositionModule()
            };

            foreach (var module in compositionModules)
            {
                module.RegisterTypes(container);
            }

            container.Verify();

            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
    }
}