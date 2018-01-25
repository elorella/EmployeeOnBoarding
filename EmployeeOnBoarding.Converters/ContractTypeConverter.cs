using System;
using EmployeeOnBoarding.Domain;

namespace EmployeeOnBoarding.Converters
{
    public class ContractTypeConverter : IContractTypeConverter
    {
        public ContractType ToDomainObject(string contractType)
        {
            switch (contractType)
            {
                case "FLTM":
                    return ContractType.FullTime;
                case "PRTM":
                    return ContractType.PartTime;
                default:
                    return ContractType.Unknown;
            }
        }

        public string ToDataTransferObject(ContractType contractType)
        {
            switch (contractType)
            {
                case ContractType.FullTime:
                    return "FLTM";
                case ContractType.PartTime:
                    return "PRTM";
                default:
                    throw new Exception("Unexpected Contract Type");
            }
        }
    }
}