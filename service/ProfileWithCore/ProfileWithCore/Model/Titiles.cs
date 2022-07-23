using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfileWithCore.Model
{
    public class Titiles : BaseModel
    {

        public string Name { get; set; }


        public int ProfileExprienceId { get; set; }
        public ProfileExprience ProfileExprience { get; set; }
    }
}
