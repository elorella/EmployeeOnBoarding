namespace EmployeeOnBoarding.Domain.Assignment
{
    public class Assignment : IEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Level { get; set; }
        public int DurationInSeconds { get; set; }
    }
}