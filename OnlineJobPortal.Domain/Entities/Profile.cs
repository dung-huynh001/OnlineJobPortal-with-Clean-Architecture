﻿using OnlineJobPortal.Domain.Common;

namespace OnlineJobPortal.Domain.Entities
{
    public class Profile : BaseEntity
    {
        public string  Title { get; set; }
        public string  CareerGoal { get; set; }
        public string  Position { get; set; }

        public int CandidateId { get; set; }
        public Candidate Candidate { get; set; }

        public ICollection<CandidateSkill> CandidateSkills { get; set; }

        public ICollection<Education>? Educations { get; set; }

        public ICollection<Experience>? Experiences { get; set; }

        public ICollection<ForeignLanguage>? ForeignLanguages { get; set; }
    }
}
