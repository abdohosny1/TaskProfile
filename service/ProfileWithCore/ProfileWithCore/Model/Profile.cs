using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfileWithCore.Model
{
   public class Profile : BaseModel
    {

        public Profile()
        {
            ProfileExprience =new List<ProfileExprience> { };
        }
     //   public string Id { get; set; }

        public string Name { get; set; }

        public virtual List<ProfileExprience> ProfileExprience { get; set; }


    }
}
