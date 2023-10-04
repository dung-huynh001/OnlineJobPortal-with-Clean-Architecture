using OnlineJobPortal.Domain.Common;
using OnlineJobPortal.Domain.Enums;

namespace OnlineJobPortal.Domain.Entities
{
    public class JobRequirement : BaseEntity
    {
        public Level Level { get; set; }

        public int JobPostId { get; set; }
        public JobPost JobPost { get; set; }

        public int SkillId { get; set; }
        public Skill Skill { get; set; }
    }
}
