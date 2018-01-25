namespace EmployeeOnBoarding.DataTransferObjects
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ContractType { get; set; }
        public string BirthDay { get; set; }
        public string StartDate { get; set; }
    }
}