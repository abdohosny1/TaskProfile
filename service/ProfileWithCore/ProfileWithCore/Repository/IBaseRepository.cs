using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProfileWithCore.Repository
{
    public interface IBaseRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<IEnumerable<T>> GetByUserID(int id);
        Task<IEnumerable<T>> GellAll(params Expression<Func<T, object>>[] includeProperty);

        Task<T> Add(T entity);
        Task AddAsync(T entity);
        Task<T> update(T entity);
        Task updateAsync(int id, T entity);

        Task DeleteAsync(int id);
        Task<T> GetById(int id);
       
    }
}
