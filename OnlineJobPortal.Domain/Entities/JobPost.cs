using OnlineJobPortal.Domain.Common;

namespace OnlineJobPortal.Domain.Entities
{
    public class JobPost : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Requirement { get; set; }
        public string Location { get; set; }
        public Decimal Salary { get; set; }
        public string Address { get; set; }
        public int NumberOfRecruits { get; set; }
        public DateTime ExpiredDate { get; set; }

        public ICollection<JobRequirement> JobRequirements { get; set; }

        public ICollection<JobFavorite>? JobFavorites { get; set; }

        public ICollection<Application>? Applications { get; set; }

        public int EmployerId { get; set; }
        public Employer Employer { get; set; }

        public int JobCategoryId { get; set; }
        public JobCategory JobCategory { get; set; }
    }
}
