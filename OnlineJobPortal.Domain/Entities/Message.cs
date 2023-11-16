using Microsoft.VisualBasic;
using OnlineJobPortal.Domain.Common;

namespace OnlineJobPortal.Domain.Entities
{
    public class Message : BaseEntity
    {
        public string Content { get; set; }
        public DateTime Timestamp { get; set; }

        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }

        public int ConversationId { get; set; }
        public virtual Conversations Conversation { get; set; }

        /*public int CandidateId { get; set; }
        public Candidate Candidate { get; set; }

        public int EmployerId { get; set; }
        public Employer Employer { get; set; }*/
    }
}
