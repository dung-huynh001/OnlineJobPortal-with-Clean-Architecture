using OnlineJobPortal.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.DTOs.EducationDto
{
    public class GetEducationDto : BaseDto
    {
        public string Major { get; set; }
        public string University { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime CompletionDate { get; set; }
        public double GPA { get; set; }
    }
}
