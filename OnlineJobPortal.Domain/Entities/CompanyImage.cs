using OnlineJobPortal.Domain.Common;

namespace OnlineJobPortal.Domain.Entities
{
    public class CompanyImage : BaseEntity
    {
        public string Url { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set;}
    }
}
