using EmployeeOnBoarding.DataTransferObjects;
using EmployeeOnBoarding.Domain;

namespace EmployeeOnBoarding.Converters
{
    public interface IEmployeeConverter
    {
        Employee ToDomainObject(EmployeeDto employeeDto);

        EmployeeDto ToDataTransferObject(Employee employee);
    }
}