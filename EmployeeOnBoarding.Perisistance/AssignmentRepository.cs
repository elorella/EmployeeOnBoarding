using EmployeeOnBoarding.Domain.Assignment;
using EmployeeOnBoarding.Perisistance.Interfaces;

namespace EmployeeOnBoarding.Perisistance
{
    public class AssignmentRepository : BaseRepository<Assignment>, IBaseRepository<Assignment>
    {
        public AssignmentRepository(MongoCredentials mongoCredentials) : base(mongoCredentials)
        {
        }
    }
}
