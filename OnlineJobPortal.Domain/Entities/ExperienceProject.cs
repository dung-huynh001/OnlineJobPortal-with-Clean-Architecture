using OnlineJobPortal.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Domain.Entities
{
    public class ExperienceProject : BaseEntity
    {
        public string Title { get; set; }
        public string Position { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ExperienceId { get; set; }
        public Experience? Experience { get; set; }
    }
}
