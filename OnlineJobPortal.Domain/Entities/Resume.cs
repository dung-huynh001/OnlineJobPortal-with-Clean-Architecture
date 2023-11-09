using OnlineJobPortal.Domain.Common;

namespace OnlineJobPortal.Domain.Entities
{
    public class Resume : BaseEntity
    {
        public string Title { get; set; }
        public string CareerGoal { get; set; }
        public string Position { get; set; }
        public string YearOfExperiences { get; set; }
        public string CvUrl { get; set; }
        public bool JobSearchMode { get; set; }

        public int CandidateId { get; set; }
        public Candidate Candidate { get; set; }

        public ICollection<Project>? Project { get; set; }

        public ICollection<CandidateSkill> CandidateSkills { get; set; }

        public ICollection<Education>? Educations { get; set; }

        public ICollection<Experience>? Experiences { get; set; }

        public ICollection<ForeignLanguage>? ForeignLanguages { get; set; }
    }
}
