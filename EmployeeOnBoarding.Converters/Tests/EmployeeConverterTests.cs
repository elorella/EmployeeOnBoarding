using System;
using EmployeeOnBoarding.DataTransferObjects;
using EmployeeOnBoarding.Domain;
using EmployeeOnBoarding.Domain.Employee;
using NUnit.Framework;

namespace EmployeeOnBoarding.Converters.Tests
{
    [TestFixture]
    public class EmployeeConverterTests
    {
        private readonly EmployeeConverter _employeeConverter;
        
        public EmployeeConverterTests()
        {
            var contractConverter = new ContractTypeConverter();
            _employeeConverter = new EmployeeConverter(contractConverter);
        }

        [Test]
        public void ConvertEmployee()
        {
            var expected = new Employee
            (
                0,
                "Elif",
                "Olgun",
                ContractType.FullTime,
                new DateTime(2018, 1, 1),
                new DateTime(1980, 1, 1)
            );

            var employeeDto = new EmployeeDto
            {
                Id = 0,
                Name = "Elif",
                Surname = "Olgun",
                ContractType = "FLTM",
                BirthDay = "1980-01-01",
                StartDate = "2018-01-01"
            };

            var actual = _employeeConverter.ToDomainObject(employeeDto);

            Assert.AreEqual(expected.Id, actual.Id);
            Assert.AreEqual(expected.BirthDay, actual.BirthDay);
            Assert.AreEqual(expected.ContractType, actual.ContractType);
            Assert.AreEqual(expected.Name, actual.Name);
            Assert.AreEqual(expected.StartDate, actual.StartDate);
            Assert.AreEqual(expected.Surname, actual.Surname);
        }

        [Test]
        public void ConvertEmployeeDto()
        {
            var expected = new EmployeeDto
            {
                Id = 0,
                Name = "Elif",
                Surname = "Olgun",
                ContractType = "FLTM",
                BirthDay = "1980-01-01",
                StartDate = "2018-01-01"
            };

            var employee = new Employee
            (
                0,
                "Elif",
                "Olgun",
                ContractType.FullTime,
                new DateTime(2018, 1, 1),
                new DateTime(1980, 1, 1)
            );

            var actual = _employeeConverter.ToDataTransferObject(employee);

            Assert.AreEqual(expected.Id, actual.Id);
            Assert.AreEqual(expected.BirthDay, actual.BirthDay);
            Assert.AreEqual(expected.ContractType, actual.ContractType);
            Assert.AreEqual(expected.Name, actual.Name);
            Assert.AreEqual(expected.StartDate, actual.StartDate);
            Assert.AreEqual(expected.Surname, actual.Surname);
        }
    }
}
