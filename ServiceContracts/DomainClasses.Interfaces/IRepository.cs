using System.Linq;

namespace ServiceContracts.DomainClasses.Interfaces
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);

        T GetById(object id);
        IQueryable<T> GetAll();
    }
}
