using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.DTOs.ResumeDto
{
    public class GetResumeToSuggestJobsDto
    {
        public List<string> skills { get; set; }
        public string experience { get; set; }
        public string education { get; set; }
    }
}
