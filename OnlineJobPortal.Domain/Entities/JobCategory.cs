using OnlineJobPortal.Domain.Common;

namespace OnlineJobPortal.Domain.Entities
{
    public class JobCategory : BaseEntity
    {
        public string JobCategoryName { get; set; }

        public ICollection<JobPost>? JobPost { get; set; }
    }
}
