using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace UniversityManager.Data.Repositories
{
    public interface IRepository<T>
        where T : class
    {
        Task<T> Add(T entity);

        Task<T> Update(T entity);

        Task<T> Get(int id);

        Task<T> GetByProperty(Expression<Func<T, bool>> predicate);

        Task<T> Delete(T entity);

        Task<IEnumerable<T>> All();

        Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate);
    }
}
