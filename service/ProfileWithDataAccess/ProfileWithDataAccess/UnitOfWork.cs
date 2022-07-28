using ProfileWithCore;
using ProfileWithCore.Model;
using ProfileWithCore.Repository;
using ProfileWithDataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfileWithDataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IBaseRepository<Profile> Profiles { get; private set; }

        public IBaseRepository<ProfileExprience> ProfileExpriences { get; private set; }

        public IBaseRepository<Cities> Citiess { get; private set; }

        public IBaseRepository<companies> companiess { get; private set; }

        public IBaseRepository<Titiles> Titiless { get; private set; }

        public IExpericence expericence { get; private set; }


        public UnitOfWork(ApplicationDbContext context)
        {

            _context = context;
            Profiles = new BaseRepository<Profile>(_context);
            ProfileExpriences = new BaseRepository<ProfileExprience>(_context);
            Citiess = new BaseRepository<Cities>(_context);
            companiess = new BaseRepository<companies>(_context);
            Titiless = new BaseRepository<Titiles>(_context);
            expericence = new Expericence(_context);
        }
        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
