using EmployeeOnBoarding.DataTransferObjects;
using EmployeeOnBoarding.Service;
using NUnit.Framework;

namespace EmployeeOnBoardingApi.Tests
{
    public class EmployeeServiceTests
    {
        [Test]
        [Explicit]
        public void AddEmployee()
        {
            var employeeService = new EmployeeService();

            employeeService.AddEmployee(new EmployeeDto
            {
                Id = 0,
                Name = "Elif",
                Surname = "Olgun",
                ContractType = "FLTM",
                BirthDay = "1980-01-01",
                StartDate = "2018-01-01"
            });
        }

        [Test]
        [Explicit]
        public void GetEmployee()
        {
            var employeeService = new EmployeeService();

            var expected = employeeService.GetEmployee(0);

            Assert.AreEqual(expected.Id, 0);
            Assert.AreEqual(expected.BirthDay, "1980-01-01");
            Assert.AreEqual(expected.ContractType, "FLTM");
            Assert.AreEqual(expected.Name, "Elif");
            Assert.AreEqual(expected.StartDate, "2018-01-01");
            Assert.AreEqual(expected.Surname, "Olgun");
        }
    }
}