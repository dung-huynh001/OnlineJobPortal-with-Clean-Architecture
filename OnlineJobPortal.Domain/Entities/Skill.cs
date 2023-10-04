using OnlineJobPortal.Domain.Common;

namespace OnlineJobPortal.Domain.Entities
{
    public class Skill : BaseEntity
    {
        public string SkillName { get; set; }

        public ICollection<CandidateSkill> CandidateSkills { get; set; }

        public ICollection<JobRequirement> JobRequirements { get; set; }
    }
}
