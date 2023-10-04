using OnlineJobPortal.Domain.Common;
using OnlineJobPortal.Domain.Enums;

namespace OnlineJobPortal.Domain.Entities
{
    public class CandidateSkill : BaseEntity
    {
        public Level Level { get; set; }

        public int ProfileId { get; set; }
        public Profile Profile { get; set; }

        public int SkillId { get; set; }
        public Skill Skill { get; set; }
    }
}
