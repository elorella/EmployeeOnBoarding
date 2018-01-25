using System;
using System.Globalization;
using EmployeeOnBoarding.DataTransferObjects;
using EmployeeOnBoarding.Domain.Employee;

namespace EmployeeOnBoarding.Converters
{
    public class EmployeeConverter
    {
        private readonly ContractTypeConverter _contractTypeConverter = new ContractTypeConverter();

        public Employee ToDomainObject(EmployeeDto employeeDto)
        {
            var contractType = _contractTypeConverter.ToDomainObject(employeeDto.ContractType);

            var startDate = DateTime.Parse(employeeDto.StartDate, CultureInfo.InvariantCulture);

            var birthDay = DateTime.Parse(employeeDto.BirthDay, CultureInfo.InvariantCulture);

            var employee = new Employee
            (
                employeeDto.Id,
                employeeDto.Name,
                employeeDto.Surname,
                contractType,
                startDate,
                birthDay
            );

            return employee;
        }

        public EmployeeDto ToDataTransferObject(Employee employee)
        {
            var contractType = _contractTypeConverter.ToDataTransferObject(employee.ContractType);
            var birthDay = employee.BirthDay.ToLocalTime().ToString("yyyy-MM-dd",CultureInfo.InvariantCulture);
            var startDate = employee.StartDate.ToLocalTime().ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

            var employeeDto = new EmployeeDto
            {
                Id = employee.Id,
                Name = employee.Name,
                Surname = employee.Surname,
                ContractType = contractType,
                BirthDay = birthDay,
                StartDate = startDate
            };

            return employeeDto;
        }
    }
}