using OnlineJobPortal.Domain.Common;
using OnlineJobPortal.Domain.Enums;

namespace OnlineJobPortal.Domain.Entities
{
    public class JobPost : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public EmploymentType EmploymentType { get; set; }
        public string Requirement { get; set; }
        public string Benefits { get; set; }
        public string Location { get; set; }
        public string Salary { get; set; }
        public string Address { get; set; }
        public string YearsOfExperience { get; set; }
        public int NumberOfRecruits { get; set; }
        public DateTime ExpiredDate { get; set; }

        public ICollection<RequirementSkill> RequirementSkills { get; set; }

        public ICollection<JobFavorite>? JobFavorites { get; set; }

        public ICollection<Apply>? Applications { get; set; }

        public int EmployerId { get; set; }
        public Employer Employer { get; set; }

        public int JobTypeId { get; set; }
        public JobType JobType { get; set; }
    }
}
