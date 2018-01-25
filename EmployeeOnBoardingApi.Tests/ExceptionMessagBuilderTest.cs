using System;
using System.Collections.Generic;
using EmployeeOnBoarding.Service;
using FluentValidation.Results;
using NUnit.Framework;

namespace EmployeeOnBoardingApi.Tests
{
    class ExceptionMessagBuilderTest
    {
        [Test]
        public void BuildExceptionMessage()
        {
            var expected = $"Invalid Name{Environment.NewLine}Invalid Surname";

            string actual = ExceptionMessageBuilder.Build(new List<ValidationFailure>
            {
                new ValidationFailure("Name", "Invalid Name"),
                new ValidationFailure("Surname", "Invalid Surname")
            });

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BuildEmptyExceptionMessage()
        {
            var expected = string.Empty;
            string actual = ExceptionMessageBuilder.Build(new List<ValidationFailure>());
            Assert.AreEqual(expected, actual);
        }
    }
}
