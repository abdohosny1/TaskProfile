using ProfileWithCore.Model;
using ProfileWithCore.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfileWithCore
{
    public interface IUnitOfWork :IDisposable
    { 
        IBaseRepository<Profile> Profiles { get; }
        IBaseRepository<ProfileExprience> ProfileExpriences { get; }
        IBaseRepository<Cities> Citiess { get; }
        IBaseRepository<companies> companiess { get; }
        IBaseRepository<Titiles> Titiless { get; }

        IExpericence expericence { get; }

        int Complete();

    }
}
