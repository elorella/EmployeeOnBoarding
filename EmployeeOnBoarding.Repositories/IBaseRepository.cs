using EmployeeOnBoarding.Domain;

namespace EmployeeOnBoarding.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : IEntity
    {
        TEntity GetById(int id);
        void Insert(TEntity entity);
    }
}