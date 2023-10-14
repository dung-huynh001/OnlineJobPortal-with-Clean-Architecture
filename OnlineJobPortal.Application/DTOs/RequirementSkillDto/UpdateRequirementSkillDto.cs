using OnlineJobPortal.Application.DTOs.Common;
using OnlineJobPortal.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.DTOs.RequirementSkillDto
{
    public class UpdateRequirementSkillDto : BaseDto
    {
        public Level Level { get; set; }
        public int JobPostId { get; set; }
        public int SkillId { get; set; }
    }
}
