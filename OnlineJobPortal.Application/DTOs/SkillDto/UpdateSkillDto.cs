using OnlineJobPortal.Application.DTOs.Common;
using OnlineJobPortal.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.DTOs.SkillDto
{
    public class UpdateSkillDto : BaseDto
    {
        public string SkillName { get; set; }
        public Level Level { get; set; }
    }
}
