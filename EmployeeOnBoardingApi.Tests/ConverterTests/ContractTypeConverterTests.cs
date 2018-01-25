using System;
using EmployeeOnBoarding.Converters;
using EmployeeOnBoarding.Domain;
using NUnit.Framework;

namespace EmployeeOnBoardingApi.Tests.ConverterTests
{
    public class ContractTypeConverterTests
    {
        [Test]
        [Category("ConverterTests")]
        public void ConvertContractTypeDto_FullTime()
        {
            var expected = "FLTM";

            var actual = new ContractTypeConverter().ToDataTransferObject(ContractType.FullTime);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        [Category("ConverterTests")]
        public void ConvertContractTypeDto_PartTime()
        {
            var expected = "PRTM";

            var actual = new ContractTypeConverter().ToDataTransferObject(ContractType.PartTime);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        [Category("ConverterTests")]
        public void ConvertContractTypeDto_Unknown()
        {
            Assert.Throws<Exception>(() => new ContractTypeConverter().ToDataTransferObject(ContractType.Unknown));
        }

        [Test]
        [Category("ConverterTests")]
        public void ConvertContractType_FullTime()
        {
            var expected = ContractType.FullTime;

            var actual = new ContractTypeConverter().ToDomainObject("FLTM");

            Assert.AreEqual(expected, actual);
        }

        [Test]
        [Category("ConverterTests")]
        public void ConvertContractType_PartTime()
        {
            var expected = ContractType.PartTime;

            var actual = new ContractTypeConverter().ToDomainObject("PRTM");

            Assert.AreEqual(expected, actual);
        }

        [Test]
        [Category("ConverterTests")]
        public void ConvertContractType_Unknown()
        {
            var expected = ContractType.Unknown;

            var actual = new ContractTypeConverter().ToDomainObject("");

            Assert.AreEqual(expected, actual);
        }
    }
}