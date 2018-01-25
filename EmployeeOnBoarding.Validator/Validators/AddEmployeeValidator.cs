using System;
using EmployeeOnBoarding.DataTransferObjects;
using FluentValidation;

namespace EmployeeOnBoarding.Validator.Validators
{
    public class AddEmployeeValidator : AbstractValidator<EmployeeDto>
    {
        public AddEmployeeValidator()
        {
            RuleFor(customer => customer.Name).NotEmpty().WithMessage("Please specify a first name");
            RuleFor(customer => customer.Surname).NotEmpty().WithMessage("Please specify a surname");
            RuleFor(customer => customer.ContractType).Length(4).WithMessage("Please specify a valid contract type.");
            RuleFor(customer => customer.Id).NotEqual(0).WithMessage("Id is zero.");
            RuleFor(customer => customer.BirthDay).Must(BeAValidDatetime)
                .WithMessage("Please specify a valid birthday. Dateformat is yyyy-MM-dd. ");
            RuleFor(customer => customer.StartDate).Must(BeAValidDatetime)
                .WithMessage("Please specify a valid birthday. Dateformat is yyyy-MM-dd. ");
        }

        private bool BeAValidDatetime(string datetime)
        {
            bool isValid = DateTime.TryParse(datetime, out var validDatetime);
            return isValid;
        }
    }
}