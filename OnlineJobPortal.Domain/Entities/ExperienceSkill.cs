using OnlineJobPortal.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Domain.Entities
{
    public class ExperienceSkill : BaseEntity
    {
        public int SkillId { get; set; }
        public int ExperienceId { get; set; }
        public Skill Skill { get; set; }
        public Experience Experience { get; set; }
    }
}
