using EmployeeOnBoarding.Domain;

namespace EmployeeOnBoarding.Converters
{
    public interface IContractTypeConverter
    {
       ContractType ToDomainObject(string contractType);

        string ToDataTransferObject(ContractType contractType);
    }
}