using System;
using NUnit.Framework;

namespace EmployeeOnBoarding.Domain.Employee
{
    [TestFixture]
    public class EmployeeTests
    {
        private readonly Employee _employee;
        private const int Id = 2;
        private const string Name = "Elif";
        private const string Surname = "Olgun";
        private const ContractType Type = ContractType.PartTime;
        private static readonly DateTime StartDate = new DateTime(2018, 1, 1);
        private static readonly DateTime BirthDay = new DateTime(1980, 1, 1);


        public EmployeeTests()
        {
            _employee = new Employee(2, Name, Surname, Type, StartDate, BirthDay);
        }

        [Test]
        public void SetAndGetId()
        {
            Assert.That(_employee.Id, Is.EqualTo(Id));
        }

        [Test]
        public void SetAndGetName()
        {
            Assert.That(_employee.Name, Is.EqualTo(Name));
        }
        [Test]
        public void SetAndGetSurname()
        {
            Assert.That(_employee.Surname, Is.EqualTo(Surname));
        }
        [Test]
        public void SetAndGetContractType()
        {
            Assert.That(_employee.ContractType, Is.EqualTo(Type));
        }
        [Test]
        public void SetAndGetStartDate()
        {
            Assert.That(_employee.StartDate, Is.EqualTo(StartDate));
        }
        [Test]
        public void SetAndGetBirthDay()
        {
            Assert.That(_employee.BirthDay, Is.EqualTo(BirthDay));
        }
    }
}