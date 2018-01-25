using System;
using EmployeeOnBoarding.Domain;
using EmployeeOnBoarding.Perisistance;
using NUnit.Framework;

namespace EmployeeOnBoardingApi.Tests.RepositoryTests
{
    public class EmployeeRepositoryTests
    {
        private static readonly MongoCredentials MongoCredentialForTest =
            new MongoCredentials("EmployeeOnboarding", "mongouser", "mongo123", "localhost");

        private readonly EmployeeRepository _employeeRepository = new EmployeeRepository(MongoCredentialForTest);

        [Test]
        [Explicit]
        [Category("Explicit")]
        public void AddEmployee()
        {
            var employee = new Employee
            (
                0,
                "Elif",
                "Olgun",
                ContractType.FullTime,
                new DateTime(1980, 1, 1),
                new DateTime(2018, 1, 1)
            );

            _employeeRepository.Insert(employee);
        }

        [Test]
        [Explicit]
        [Category("Explicit")]
        public void GetEmployeeById()
        {
            var employee = _employeeRepository.GetById(0);

            Assert.True(employee != null);
        }
    }
}