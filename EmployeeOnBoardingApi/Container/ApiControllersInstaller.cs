using System.Web.Http;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace EmployeeOnBoardingApi.Container
{
    public class ApiControllersInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Classes.FromThisAssembly()
                .BasedOn<ApiController>()
                .LifestylePerWebRequest());

            //GlobalConfiguration.Configuration.MessageHandlers.Add(new MessageHandler());

        }
    }
}