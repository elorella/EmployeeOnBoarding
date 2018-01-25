using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using EmployeeOnBoarding.Converters;
using EmployeeOnBoarding.Perisistance;
using EmployeeOnBoarding.Perisistance.Interfaces;
using EmployeeOnBoarding.Service;

namespace EmployeeOnBoardingApi.Container
{
    public class Installer : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            var dbName = "EmployeeOnboarding";
            var username = "mongouser";
            var pwd = "mongo123";
            var server = "localhost";

            container.Register(Component.For<EmployeeOnBoarding.Validator.IValidator>()
                .ImplementedBy<EmployeeOnBoarding.Validator.Validator>().LifeStyle.PerWebRequest);
            container
                .Register(Component.For<IEmployeeRepository>()
                    .ImplementedBy<EmployeeRepository>().LifeStyle.PerWebRequest);
            container.Register(Component.For<EmployeeService>().LifeStyle.PerWebRequest);
            container.Register(Component.For<MongoCredentials>().DependsOn(Dependency.OnValue("databaseName", dbName))
                .DependsOn(Dependency.OnValue("databaseName", dbName))
                .DependsOn(Dependency.OnValue("userName", username))
                .DependsOn(Dependency.OnValue("password", pwd))
                .DependsOn(Dependency.OnValue("serverAddress", server))
                .LifeStyle.Singleton);
            container.Register(Component.For<IEmployeeConverter>().ImplementedBy<EmployeeConverter>()
                .LifestylePerWebRequest());
            container.Register(Component.For<IContractTypeConverter>().ImplementedBy<ContractTypeConverter>()
                .LifestylePerWebRequest());

        }
    }
}