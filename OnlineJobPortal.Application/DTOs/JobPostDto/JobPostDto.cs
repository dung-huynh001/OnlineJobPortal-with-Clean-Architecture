using OnlineJobPortal.Application.DTOs.Common;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.DTOs.JobPostDto
{
    public class JobPostDto : BaseDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Requirement { get; set; }
        public string Location { get; set; }
        public Decimal Salary { get; set; }
        public string Address { get; set; }
        public int NumberOfRecruits { get; set; }
        public DateTime ExpiredDate { get; set; }

        public ICollection<RequirementSkill> RequirementSkills { get; set; }

        public ICollection<JobFavorite>? JobFavorites { get; set; }

        public ICollection<OnlineJobPortal.Domain.Entities.Application>? Applications { get; set; }

        public ICollection<ForeignLanguage>? ForeignLanguages { get; set; }

        public int EmployerId { get; set; }
        public Employer Employer { get; set; }

        public int JobTypeId { get; set; }
        public JobType JobType { get; set; }
    }
}
