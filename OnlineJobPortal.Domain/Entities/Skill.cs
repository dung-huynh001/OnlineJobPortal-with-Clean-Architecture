﻿using OnlineJobPortal.Domain.Common;

namespace OnlineJobPortal.Domain.Entities
{
    public class Skill : BaseEntity
    {
        public string SkillName { get; set; }

        public ICollection<CandidateSkill> CandidateSkills { get; set; }
        public ICollection<ExperienceSkill> ExperienceSkills { get; set; }
        public ICollection<RequirementSkill> RequirementSkills { get; set; }
    }
}
