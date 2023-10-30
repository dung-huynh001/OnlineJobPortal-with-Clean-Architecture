using OnlineJobPortal.Domain.Common;

namespace OnlineJobPortal.Domain.Entities
{
    public class JobType : BaseEntity
    {
        public string JobTypeName { get; set; }
        public string JobTypeIcon { get; set; }

        public ICollection<JobPost>? JobPost { get; set; }
    }
}
