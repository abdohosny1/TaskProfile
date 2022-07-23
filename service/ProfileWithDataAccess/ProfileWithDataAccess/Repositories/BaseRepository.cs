using Microsoft.EntityFrameworkCore;
using ProfileWithCore.Model;
using ProfileWithCore.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProfileWithDataAccess.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseModel
    {
        private readonly ApplicationDbContext _context;

        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }
        public async Task<IEnumerable<T>> GellAll(params Expression<Func<T, object>>[] includeProperty)
        {
            IQueryable<T> quary = _context.Set<T>();
            quary = includeProperty.Aggregate(quary, (current, includeProperty)
                                   => current.Include(includeProperty));

            return await quary.ToListAsync();
        }

        public  T Add(T entity)
        {
             _context.Set<T>().Add(entity);
            _context.SaveChanges();
            return entity;

        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

      

        public Task<T> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public T Update(T entity)
        {
            throw new NotImplementedException();
        }

     
    }
}
