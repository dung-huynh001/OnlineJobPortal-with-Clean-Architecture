using OnlineJobPortal.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.DTOs.JobTypeDto
{
    public class GetJobTypeDto : BaseDto
    {
        public string JobTypeName { get; set; }
    }
}
