using OnlineJobPortal.Application.DTOs.Common;
using OnlineJobPortal.Domain.Entities;
using OnlineJobPortal.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.DTOs.CandidateSkillDto
{
    public class UpdateCandidateSkillDto : BaseDto
    {
        public Level Level { get; set; }

        public int ResumeId { get; set; }

        public int SkillId { get; set; }
    }
}
