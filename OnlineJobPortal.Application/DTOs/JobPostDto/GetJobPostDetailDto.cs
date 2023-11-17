using OnlineJobPortal.Application.DTOs.Common;
using OnlineJobPortal.Application.DTOs.CompanyDto;
using OnlineJobPortal.Application.DTOs.JobTypeDto;
using OnlineJobPortal.Application.DTOs.RequirementSkillDto;
using OnlineJobPortal.Application.DTOs.SkillDto;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.DTOs.JobPostDto
{
    public class GetJobPostDetailDto : BaseDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string EmploymentType { get; set; }
        public string Requirement { get; set; }
        public string Benefits { get; set; }
        public string ProvinceName { get; set; }
        public string Salary { get; set; }
        public string Address { get; set; }
        public string YearsOfExperience { get; set; }
        public int NumberOfRecruits { get; set; }
        public string ExpiredDate { get; set; }
        public int JobTypeId { get; set; }
        public bool Saved { get; set; } = false;
        public GetJobTypeDto JobType { get; set; }
        public GetCompanyDto Company { get; set; }
        public ICollection<GetRequirementSkillDto> RequirementSkills { get; set; }
    }
}
