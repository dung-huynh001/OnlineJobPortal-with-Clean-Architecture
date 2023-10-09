using OnlineJobPortal.Domain.Common;

namespace OnlineJobPortal.Domain.Entities
{
    public class Education : BaseEntity
    {
        public string Certificate { get; set; }
        public string Major { get; set; }
        public string University { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime CompletionDate { get; set; }
        public double GPA { get; set; }

        public int? ResumeId { get; set; }
        public Resume? Resume { get; set; }
    }
}
