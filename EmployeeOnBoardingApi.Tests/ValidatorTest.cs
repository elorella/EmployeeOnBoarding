using System;
using System.Collections.Generic;
using EmployeeOnBoarding.DataTransferObjects;
using EmployeeOnBoarding.Service;
using EmployeeOnBoarding.Validator.Validators;
using FluentValidation.Results;
using NUnit.Framework;

namespace EmployeeOnBoardingApi.Tests
{
    class AddEmployeeValidatorTest
    {
        [Test]
        public void AddEmployeeValid()
        {
            var employee = new EmployeeDto()
            {
                Id = 1,
                Surname = "Duck",
                Name = "Donald",
                BirthDay = "1984-11-13",
                StartDate = "2018-01-25",
                ContractType = "PRTM"
            };

            var addEmployeeValidator = new AddEmployeeValidator();
            var result = addEmployeeValidator.Validate(employee);

            Assert.AreEqual(result.Errors.Count,0 );
        }

        [Test]
        public void NameIsEmptyErrorExpected()
        {
            var employee = new EmployeeDto()
            {
                Id = 1,
                Surname = "Duck",
                Name = "",
                BirthDay = "1984-11-13",
                StartDate = "2018-01-25",
                ContractType = "PRTM"
            };

            var addEmployeeValidator = new AddEmployeeValidator();
            var result = addEmployeeValidator.Validate(employee);

            Assert.AreEqual(result.Errors.Count, 1);
        }

        [Test]
        public void IdIsZeroErrorExpected()
        {
            var employee = new EmployeeDto()
            {
                Id = 0,
                Surname = "Duck",
                Name = "Donald",
                BirthDay = "1984-11-13",
                StartDate = "2018-01-25",
                ContractType = "PRTM"
            };

            var addEmployeeValidator = new AddEmployeeValidator();
            var result = addEmployeeValidator.Validate(employee);

            Assert.AreEqual(result.Errors.Count, 1);
        }

        [Test]
        public void SurNameIsEmptyErrorExpected()
        {
            var employee = new EmployeeDto()
            {
                Id = 1,
                Surname = "",
                Name = "Donald",
                BirthDay = "1984-11-13",
                StartDate = "2018-01-25",
                ContractType = "PRTM"
            };


            var addEmployeeValidator = new AddEmployeeValidator();
            var result = addEmployeeValidator.Validate(employee);

            Assert.AreEqual(result.Errors.Count, 1);
        }

        [Test]
        public void ContractTypeIsShoterThen4ErrorExpected()
        {
            var employee = new EmployeeDto()
            {
                Id = 1,
                Surname = "Duck",
                Name = "Donald",
                BirthDay = "1984-11-13",
                StartDate = "2018-01-25",
                ContractType = "PRM"
            };


            var addEmployeeValidator = new AddEmployeeValidator();
            var result = addEmployeeValidator.Validate(employee);

            Assert.AreEqual(result.Errors.Count, 1);
        }

        [Test]
        public void ContractTypeIsLongerThen4ErrorExpected()
        {
            var employee = new EmployeeDto()
            {
                Id = 1,
                Surname = "Duck",
                Name = "Donald",
                BirthDay = "1984-11-13",
                StartDate = "2018-01-25",
                ContractType = "PRMPR"
            };


            var addEmployeeValidator = new AddEmployeeValidator();
            var result = addEmployeeValidator.Validate(employee);

            Assert.AreEqual(result.Errors.Count, 1);
        }

        [Test]
        public void BirthDateIsNotValidErrorExpected()
        {
            var employee = new EmployeeDto()
            {
                Id = 1,
                Surname = "Duck",
                Name = "Donald",
                BirthDay = "A-11-13",
                StartDate = "2018-01-25",
                ContractType = "PRTM"
            };

            var addEmployeeValidator = new AddEmployeeValidator();
            var result = addEmployeeValidator.Validate(employee);

            Assert.AreEqual(result.Errors.Count, 1);
        }

        [Test]
        public void StartDateIsNotValidErrorExpected()
        {
            var employee = new EmployeeDto()
            {
                Id = 1,
                Surname = "Duck",
                Name = "Donald",
                BirthDay = "1984-11-13",
                StartDate = "A-01-25",
                ContractType = "PRTM"
            };

            var addEmployeeValidator = new AddEmployeeValidator();
            var result = addEmployeeValidator.Validate(employee);

            Assert.AreEqual(result.Errors.Count, 1);
        }


        [Test]
        public void StartDateAndBirthDateIsNotValidMoreThen1ErrorExpected()
        {
            var employee = new EmployeeDto()
            {
                Id = 1,
                Surname = "Duck",
                Name = "Donald",
                BirthDay = "G-11-13",
                StartDate = "A-01-25",
                ContractType = "PRTM"
            };

            var addEmployeeValidator = new AddEmployeeValidator();
            var result = addEmployeeValidator.Validate(employee);

            Assert.AreEqual(result.Errors.Count, 2);
        }

    }
}
