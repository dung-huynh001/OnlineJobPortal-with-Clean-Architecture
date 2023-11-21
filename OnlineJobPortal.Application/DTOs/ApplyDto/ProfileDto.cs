using OnlineJobPortal.Application.DTOs.Common;
using OnlineJobPortal.Application.DTOs.EducationDto;
using OnlineJobPortal.Application.DTOs.ExperienceDto;
using OnlineJobPortal.Application.DTOs.ForeignLanguageDto;
using OnlineJobPortal.Application.DTOs.ProjectDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.DTOs.ApplyDto
{
    public class ProfileDto : BaseDto
    {
        public string FullName { get; set; }
        public string Status { get; set; }
        public string CoverLetter { get; set; }
        public string CvUrl { get; set; }
        public string AvatarUrl { get; set; }
        public string Position { get; set; }
        public string YearOfExperiences { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public List<string> Skills { get; set; }
        public List<GetExperienceDto> Experiences { get; set; }
        public List<GetEducationDto> Educations { get; set; }
        public List<GetProjectDto> Projects { get; set; }
        public List<GetForeignLanguageDto> ForeignLanguages { get; set; }
    }
}
