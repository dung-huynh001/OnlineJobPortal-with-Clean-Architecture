using OnlineJobPortal.Domain.Common;
using OnlineJobPortal.Domain.Enums;

namespace OnlineJobPortal.Domain.Entities
{
    public class Employer : BaseEntity
    {
        public string FullName { get; set; }
        public string NationalId { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string AvatarUrl { get; set; }
        public Position Position { get; set; }

        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        public ICollection<Message>? Messages { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }

        public ICollection<JobPost>? JobPosts { get; set; }
    }
}
