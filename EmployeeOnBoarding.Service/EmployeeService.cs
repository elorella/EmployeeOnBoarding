﻿using System;
using System.Linq;
using EmployeeOnBoarding.Converters;
using EmployeeOnBoarding.DataTransferObjects;
using EmployeeOnBoarding.Perisistance.Interfaces;
using EmployeeOnBoarding.Validator;

namespace EmployeeOnBoarding.Service
{
    public class EmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IValidator _validator;
        private readonly IEmployeeConverter _employeeConverter;

        public EmployeeService(IValidator validator, IEmployeeRepository employeeRepository, IEmployeeConverter employeeConverter)
        {
            _validator = validator;
            _employeeRepository = employeeRepository;
            _employeeConverter = employeeConverter;
        }

        public void AddEmployee(EmployeeDto employeeDto)
        {
            var validationResult = _validator.ValidateAddEmployee(employeeDto);
            if (validationResult.Errors.Any())
            {
                var exceptionMessage = ExceptionMessageBuilder.Build(validationResult.Errors);
                throw new ArgumentException(exceptionMessage);
            }

            var employee = _employeeConverter.ToDomainObject(employeeDto);
            _employeeRepository.Insert(employee);
        }

        public EmployeeDto GetEmployee(int id)
        {
            var employee = _employeeRepository.GetById(id);
            if (employee == null)
            {
                throw new ArgumentNullException(nameof(id), "Employee not found.");
            }

            var employeeDto = _employeeConverter.ToDataTransferObject(employee);
            return employeeDto;
        }

    }
}