using System.Web.Http;
using System.Web.Http.Dispatcher;
using System.Web.Http.ExceptionHandling;
using Castle.Windsor;
using EmployeeOnBoardingApi.Container;

namespace EmployeeOnBoardingApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config, IWindsorContainer container)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Services.Replace(typeof(IExceptionHandler), new ApiExceptionHandler());

            GlobalConfiguration.Configuration.Services.Replace(typeof(IHttpControllerActivator),
                new WindsorCompositionRoot(container));
        }
    }
}
