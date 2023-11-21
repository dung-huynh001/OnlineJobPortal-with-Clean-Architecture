using OnlineJobPortal.Application.DTOs.Common;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.DTOs.ExperienceDto
{
    public class GetExperienceDto : BaseDto
    {
        public string Position { get; set; }
        public string CompanyName { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<string> Skills { get; set; }
        public List<GetExperienceProjectDto> Projects { get; set; }
    }
}
