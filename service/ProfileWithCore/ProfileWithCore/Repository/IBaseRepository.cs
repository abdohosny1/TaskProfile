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
        Task<IEnumerable<T>> GellAll(params Expression<Func<T, object>>[] includeProperty);

        T Add(T entity);

        T Update(T entity);
        void Delete(T entity);

        Task<T> GetById(int id);
    }
}
