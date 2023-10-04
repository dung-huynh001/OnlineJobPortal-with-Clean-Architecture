using OnlineJobPortal.Domain.Common;

namespace OnlineJobPortal.Domain.Entities
{
    public class Application : BaseEntity
    {
        public int Status { get; set; }

        public int CandidateId { get; set; }
        public Candidate Candidate { get; set; }

        public int JobPostId { get; set; }
        public JobPost JobPost { get; set; }
    }
}
