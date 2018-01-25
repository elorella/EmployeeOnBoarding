using EmployeeOnBoarding.Domain;
using EmployeeOnBoarding.Perisistance.Interfaces;

namespace EmployeeOnBoarding.Perisistance
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(MongoCredentials mongoCredentials) : base(mongoCredentials)
        {
        }
    }
}
