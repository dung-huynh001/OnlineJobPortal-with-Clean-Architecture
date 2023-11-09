using OnlineJobPortal.Domain.Common;

namespace OnlineJobPortal.Domain.Entities
{
    public class Experience : BaseEntity
    {
        public string Position { get; set; }
        public string CompanyName { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ResumeId { get; set; }
        public Resume Resume { get; set; }
        public ICollection<Skill>? Skills { get; set; }
        public ICollection<Project>? Projects { get; set; }
    }
}
