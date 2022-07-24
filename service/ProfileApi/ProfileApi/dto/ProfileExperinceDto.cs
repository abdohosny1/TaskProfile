namespace ProfileApi.dto
{
    public class ProfileExperinceDto
    {

        public string CompanyName { get; set; }

        public string Branch { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

        public string StartDate { get; set; }
        public string EndDate { get; set; }

        public bool Current { get; set; }
        public bool Skill { get; set; }


        public int ProfileId { get; set; }



    }
}
