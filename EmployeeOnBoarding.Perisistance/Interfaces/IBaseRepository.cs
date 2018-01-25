using System.Collections.Generic;
using EmployeeOnBoarding.Domain;

namespace EmployeeOnBoarding.Perisistance.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : IEntity
    {
        IEnumerable<TEntity> Get();
        TEntity GetById(int id);
        void Insert(TEntity entity);
        void Delete(int id);
        void Update(TEntity entity);

    }
}