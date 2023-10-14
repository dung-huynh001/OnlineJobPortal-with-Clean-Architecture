using OnlineJobPortal.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.DTOs.ApplyDto
{
    public class CreateApplyDto
    {
        public int Status { get; set; }
        public int CandidateId { get; set; }
        public int JobPostId { get; set; }
    }
}
