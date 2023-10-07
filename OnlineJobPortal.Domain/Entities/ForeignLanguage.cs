using OnlineJobPortal.Domain.Common;

namespace OnlineJobPortal.Domain.Entities
{
    public class ForeignLanguage : BaseEntity
    {
        public string LanguageName { get; set; }
        public string Proficiency { get; set; }
        public string Degree { get; set; }

        public int ProfileId { get; set; }
        public Profile Profile { get; set; }
    }
}
