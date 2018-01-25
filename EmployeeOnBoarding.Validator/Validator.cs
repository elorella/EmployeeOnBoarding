using EmployeeOnBoarding.DataTransferObjects;
using EmployeeOnBoarding.Validator.Validators;
using FluentValidation.Results;

namespace EmployeeOnBoarding.Validator
{
    public class Validator : IValidator
    {
        public ValidationResult ValidateAddEmployee(EmployeeDto employee)
        {
            return new AddEmployeeValidator().Validate(employee);
        }
    }
}