using EmployeeOnBoarding.Converters;
using EmployeeOnBoarding.DataTransferObjects;
using EmployeeOnBoarding.Perisistance;
using EmployeeOnBoarding.Service;
using EmployeeOnBoarding.Validator;
using NUnit.Framework;

namespace EmployeeOnBoardingApi.Tests.ServiceTests
{
    public class EmployeeServiceTests
    {
        private static readonly MongoCredentials MongoCredentialForTest =
            new MongoCredentials("EmployeeOnboarding", "mongouser", "mongo123", "localhost");

        private readonly Validator _validator = new Validator();
        private readonly EmployeeRepository _employeeRepository = new EmployeeRepository(MongoCredentialForTest);
        private readonly EmployeeConverter _employeeConverter = new EmployeeConverter(new ContractTypeConverter());
        
        [Test]
        [Explicit]
        [Category("Explicit")]
        public void AddEmployee()
        {
            var employeeService = new EmployeeService(
                _validator,
                _employeeRepository, 
                _employeeConverter
                );

            employeeService.AddEmployee(new EmployeeDto
            {
                Id = 100,
                Name = "Elif",
                Surname = "Olgun",
                ContractType = "FLTM",
                BirthDay = "1980-01-01",
                StartDate = "2018-01-01"
            });
        }

        [Test]
        [Explicit]
        [Category("Explicit")]
        public void GetEmployee()
        {
            var employeeService =
                new EmployeeService(_validator,
                    _employeeRepository,
                    _employeeConverter);

            var expected = employeeService.GetEmployee(100);

            Assert.AreEqual(expected.Id, 100);
            Assert.AreEqual(expected.BirthDay, "1980-01-01");
            Assert.AreEqual(expected.ContractType, "FLTM");
            Assert.AreEqual(expected.Name, "Elif");
            Assert.AreEqual(expected.StartDate, "2018-01-01");
            Assert.AreEqual(expected.Surname, "Olgun");
        }
    }
}