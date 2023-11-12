using OnlineJobPortal.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Domain.Entities
{
    public class Project : BaseEntity
    {
        public string Title { get; set; }
        public string Position { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string LinkGit { get; set; }
        public string Description { get; set; }
        public int ResumeId { get; set; }
        public Resume? Resume { get; set; }
    }
}
