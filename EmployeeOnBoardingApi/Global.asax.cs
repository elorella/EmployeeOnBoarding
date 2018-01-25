using System.Web.Http;
using Castle.MicroKernel.Resolvers.SpecializedResolvers;
using Castle.Windsor;
using Castle.Windsor.Installer;
using EmployeeOnBoardingApi.Container;


namespace EmployeeOnBoardingApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            var container = new WindsorContainer();
            container.Install(FromAssembly.This());
            container.Kernel.Resolver.AddSubResolver(new CollectionResolver(container.Kernel, true));
            var dependencyResolver = new WindsorDependencyResolver(container);
            GlobalConfiguration.Configuration.DependencyResolver = dependencyResolver;

            GlobalConfiguration.Configure(c => WebApiConfig.Register(c, container));

        }


    }
}
