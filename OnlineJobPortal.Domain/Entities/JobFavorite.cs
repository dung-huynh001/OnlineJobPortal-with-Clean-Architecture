using OnlineJobPortal.Domain.Common;
using OnlineJobPortal.Domain.Enums;

namespace OnlineJobPortal.Domain.Entities
{
    public class JobFavorite : BaseEntity
    {
        public Rating Star { get; set; }

        public int CandidateId { get; set; }
        public Candidate Candidate { get; set; }

        public int JobPostId { get; set; }
        public JobPost JobPost { get; set; }
    }
}
