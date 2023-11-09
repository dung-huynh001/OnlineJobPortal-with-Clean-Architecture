using OnlineJobPortal.Domain.Common;

namespace OnlineJobPortal.Domain.Entities
{
    public class ForeignLanguage : BaseEntity
    {
        public string LanguageName { get; set; }
        public string Degree { get; set; }
        public int ResumeId { get; set; }
        public Resume Resume { get; set; }
    }
}
