using EmployeeOnBoarding.Converters;
using EmployeeOnBoarding.DataTransferObjects;
using EmployeeOnBoarding.Repositories;

namespace EmployeeOnBoarding.Service
{
    public class EmployeeService
    {
        private readonly EmployeeRepository _employeeRepository = new EmployeeRepository();
        private readonly EmployeeConverter _employeeConverter = new EmployeeConverter();

        public void AddEmployee(EmployeeDto employeeDto)
        {
            var employee = _employeeConverter.ToDomainObject(employeeDto);

            _employeeRepository.Insert(employee);
        }

        public EmployeeDto GetEmployee(int id)
        {
            var employee = _employeeRepository.GetById(id);

            var employeeDto = _employeeConverter.ToDataTransferObject(employee);

            return employeeDto;
        }
    }
}