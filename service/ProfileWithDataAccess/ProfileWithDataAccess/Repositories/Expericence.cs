using Microsoft.EntityFrameworkCore;
using ProfileWithCore.Model;
using ProfileWithCore.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfileWithDataAccess.Repositories
{
  public  class Expericence : BaseRepository<ProfileExprience>, IExpericence
    {
        private readonly ApplicationDbContext _context;

        public Expericence(ApplicationDbContext context):base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ProfileExprience>> GetByIdProfile(string UserId)
        {
          //return await _context.ProfileExpriences
          //   .Where(x => x.UserID == UserId).ToListAsync();
            var experList = await _context.ProfileExpriences
                      .Where(o => o.UserID == UserId)
                      .ToListAsync();

            return experList;
        }
    }
}
