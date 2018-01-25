using System.Web.Http;
using EmployeeOnBoarding.DataTransferObjects;
using EmployeeOnBoarding.Service;

namespace EmployeeOnBoardingApi.Controllers
{
    public class EmployeeController : ApiController
    {
        private readonly EmployeeService _employeeService;

        public EmployeeController(EmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        // GET: api/Employee
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //GET: api/Employee/5
        public EmployeeDto Get(int id)
        {
            return _employeeService.GetEmployee(id);
        }

        // POST: api/Employee
        public void Post([FromBody]EmployeeDto employeeDto)
        {
            _employeeService.AddEmployee(employeeDto);
        }

        //// PUT: api/Employee/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/Employee/5
        //public void Delete(int id)
        //{
        //}
    }
}
