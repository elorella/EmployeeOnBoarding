using EmployeeOnBoarding.DataTransferObjects;
using FluentValidation.Results;

namespace EmployeeOnBoarding.Validator
{
    public interface IValidator
    {
        ValidationResult ValidateAddEmployee(EmployeeDto employee);
    }
}