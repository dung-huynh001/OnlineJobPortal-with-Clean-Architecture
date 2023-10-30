using OnlineJobPortal.Application.DTOs.Common;
using OnlineJobPortal.Application.DTOs.SkillDto;
using OnlineJobPortal.Domain.Entities;
using OnlineJobPortal.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.DTOs.RequirementSkillDto
{
    public class GetRequirementSkillDto : BaseDto
    {
        public Level Level { get; set; }
        public int SkillId { get; set; }
        public GetSkillDto Skill { get; set; }
    }
}
