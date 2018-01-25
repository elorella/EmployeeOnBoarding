using System;
using EmployeeOnBoarding.Domain;
using NUnit.Framework;

namespace EmployeeOnBoardingApi.Tests.DomainTest
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
        [Category("DomainTests")]
        public void SetAndGetId()
        {
            Assert.That(_employee.Id, Is.EqualTo(Id));
        }

        [Test]
        [Category("DomainTests")]
        public void SetAndGetName()
        {
            Assert.That(_employee.Name, Is.EqualTo(Name));
        }

        [Test]
        [Category("DomainTests")]
        public void SetAndGetSurname()
        {
            Assert.That(_employee.Surname, Is.EqualTo(Surname));
        }

        [Test]
        [Category("DomainTests")]
        public void SetAndGetContractType()
        {
            Assert.That(_employee.ContractType, Is.EqualTo(Type));
        }

        [Test]
        [Category("DomainTests")]
        public void SetAndGetStartDate()
        {
            Assert.That(_employee.StartDate, Is.EqualTo(StartDate));
        }

        [Test]
        [Category("DomainTests")]
        public void SetAndGetBirthDay()
        {
            Assert.That(_employee.BirthDay, Is.EqualTo(BirthDay));
        }
    }
}