using System;
using EmployeeOnBoarding.Domain;
using EmployeeOnBoarding.Domain.Employee;
using EmployeeOnBoarding.Repositories;
using NUnit.Framework;

namespace EmployeeOnBoardingApi.Tests
{
    public class EmployeeRepositoryTests
    {
        private readonly EmployeeRepository _employeeRepository = new EmployeeRepository();

        [Test]
        [Explicit]
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
        public void GetEmployeeById()
        {
            var employee = _employeeRepository.GetById(0);

            Assert.True(employee != null);
        }
    }
}