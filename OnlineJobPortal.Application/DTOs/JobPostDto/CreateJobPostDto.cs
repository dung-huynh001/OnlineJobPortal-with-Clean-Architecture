using OnlineJobPortal.Application.DTOs.RequirementSkillDto;
using OnlineJobPortal.Domain.Entities;
using OnlineJobPortal.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.DTOs.JobPostDto
{
    public class CreateJobPostDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public EmploymentType EmploymentType { get; set; }
        public string Requirement { get; set; }
        public string Benefits { get; set; }
        public int ProvinceId { get; set; }
        public int DistrictId { get; set; }
        public string Salary { get; set; }
        public string Address { get; set; }
        public string YearsOfExperience { get; set; }
        public int NumberOfRecruits { get; set; }
        public DateTime ExpiredDate { get; set; }
        public int EmployerId { get; set; }
        public int JobTypeId { get; set; }
        public ICollection<CreateRequirementSkillDto> Skills { get; set; }
        public Level Level { get; set; }
    }
}
