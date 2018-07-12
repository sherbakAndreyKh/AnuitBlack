using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Ninject;
using Ninject.Modules;
using Ninject.Web.Mvc;
using BlackJackMVC.BLL.Infrastructure;
using BlackJackMVC.WEB.Util;

namespace BlackJackMVC.WEB
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //Внедрение зависимостей
            NinjectModule Module = new BlackJackModule();
            NinjectModule ServiceModel = new ServiceModule("DefaultConnection");
            var kernel = new StandardKernel(Module, ServiceModel);
            DependencyResolver.SetResolver(new NinjectDependencyResolver(kernel));
        }
    }
}
