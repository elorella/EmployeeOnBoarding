using EmployeeOnBoarding.Domain;

namespace EmployeeOnBoarding.Perisistance.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : IEntity
    {
        TEntity GetById(int id);
        void Insert(TEntity entity);
        void Delete(int id);
        void Update(TEntity entity);

    }
}