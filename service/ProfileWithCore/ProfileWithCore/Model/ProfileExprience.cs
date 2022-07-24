using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfileWithCore.Model
{
    public class ProfileExprience : BaseModel
    {


        public string CompanyName { get; set; }

        public string Branch { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

        public string StartDate { get; set; }
        public string EndDate { get; set; }

        public bool Current { get; set; }
        public bool Skill { get; set; }

        // [ForeignKey("Department")]

        //navigation prop
        public int ProfileId { get; set; }

        public Profile Profile { get; set; }


        //public int TitilesId { get; set; }
        //public Titiles Titiles { get; set; }




    }
}
