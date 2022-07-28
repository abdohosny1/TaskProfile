using ProfileWithCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfileWithCore.Repository
{
   public interface IExpericence : IBaseRepository<ProfileExprience>
    {
        Task<IEnumerable<ProfileExprience>> GetByIdProfile(string UserId);
    }
}
