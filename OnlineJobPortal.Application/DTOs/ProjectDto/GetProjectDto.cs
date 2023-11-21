using OnlineJobPortal.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.DTOs.ProjectDto
{
    public class GetProjectDto : BaseDto
    {
        public string Title { get; set; }
        public string Position { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string LinkGit { get; set; }
        public string Description { get; set; }
    }
}
