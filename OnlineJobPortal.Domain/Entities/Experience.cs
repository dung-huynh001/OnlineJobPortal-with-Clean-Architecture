using OnlineJobPortal.Domain.Common;

namespace OnlineJobPortal.Domain.Entities
{
    public class Experience : BaseEntity
    {
        public string JobTitle { get; set; }
        public string CompanyName { get; set; }
        public string Description { get; set; }

        public int ProfileId { get; set; }
        public Profile Profile { get; set; }
    }
}
