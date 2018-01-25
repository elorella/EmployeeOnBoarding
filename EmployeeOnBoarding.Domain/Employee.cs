using System;

namespace EmployeeOnBoarding.Domain
{
    public class Employee : IEntity
    {
        public Employee(int id, string name, string surname, ContractType contractType, DateTime startDate,
            DateTime birthDay)
        {
            Id = id;
            Name = name;
            Surname = surname;
            ContractType = contractType;
            StartDate = startDate;
            BirthDay = birthDay;
        }

        public int Id { get; }
        public string Name { get; }
        public string Surname { get; }
        public ContractType ContractType { get; }
        public DateTime StartDate { get; }
        public DateTime BirthDay { get; }
    }
}