using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
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

        public async Task<T> Add(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;

        }

        public async Task AddAsync(T entity)
        {
            _context.Set<T>().Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<T> Delete(T entity)
        {
           _context.Set<T>().Remove(entity);
            _context.SaveChanges();
            return entity;
        }
     

        public async Task DeleteAsync(int id)
        {
            var data = await _context.Set<T>().FindAsync(id);

            EntityEntry entityEntry = _context.Entry<T>(data);
            entityEntry.State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }



        public async Task<T> GetById(int id)
        {
           return await _context.Set<T>().FindAsync(id);
        }

     

        public async Task<T> update(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task updateAsync(int id, T entity)
        {
            EntityEntry entityEntry = _context.Entry<T>(entity);
            entityEntry.State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

 
    }
}
