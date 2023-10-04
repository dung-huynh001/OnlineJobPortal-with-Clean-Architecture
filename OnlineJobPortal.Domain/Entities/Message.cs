using OnlineJobPortal.Domain.Common;

namespace OnlineJobPortal.Domain.Entities
{
    public class Message : BaseEntity
    {
        public string Content { get; set; }

        public int CandidateId { get; set; }
        public Candidate Candidate { get; set; }

        public int EmployerId { get; set; }
        public Employer Employer { get; set; }
    }
}
