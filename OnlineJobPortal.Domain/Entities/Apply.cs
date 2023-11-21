using OnlineJobPortal.Domain.Common;

namespace OnlineJobPortal.Domain.Entities
{
    public class Apply : BaseEntity
    {
        public string Status { get; set; }
        public string CoverLetter { get; set; }
        public string CvUrl { get; set; }

        public int CandidateId { get; set; }
        public Candidate Candidate { get; set; }

        public int JobPostId { get; set; }
        public JobPost JobPost { get; set; }

        public int ConversationId { get; set; }
        public Conversations? Conversations { get; set; }
    }
}
