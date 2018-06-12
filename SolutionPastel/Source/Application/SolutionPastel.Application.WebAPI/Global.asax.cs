using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using SolutionPastel.Application.Service.Mapping;
using SolutionPastel.Infra.IoC.BootsTrapper;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;


namespace SolutionPastel.Application.WebAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            
                AreaRegistration.RegisterAllAreas();
                GlobalConfiguration.Configure(WebApiConfig.Register);
                FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
                RouteConfig.RegisterRoutes(RouteTable.Routes);
                BundleConfig.RegisterBundles(BundleTable.Bundles);


                RegisterMappings.Now();

                //Register Services
                var container = IoCManager.Inject();

                //Register controllers
                container.RegisterWebApiControllers(GlobalConfiguration.Configuration);

                //Verifying Register Consistency
                container.Verify();


                // Adding instances to global configuration
                GlobalConfiguration.Configuration.DependencyResolver =
                    new SimpleInjectorWebApiDependencyResolver(container);
            
        }
    }
}
    