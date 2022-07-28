using System;

namespace ProfileApi.dto
{
    public class ProfileExperinceDto
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }

        public string Branch { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }
        public string UserID { get; set; }


        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public bool Current { get; set; }
        public bool Skill { get; set; }


        public int ProfileId { get; set; }



    }
}
