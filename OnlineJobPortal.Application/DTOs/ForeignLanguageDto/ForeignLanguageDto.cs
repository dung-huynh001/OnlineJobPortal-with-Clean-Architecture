using OnlineJobPortal.Application.DTOs.Common;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.DTOs.ForeignLanguageDto
{
    public class ForeignLanguageDto : BaseDto
    {
        public string LanguageName { get; set; }
        public string Proficiency { get; set; }
        public string Degree { get; set; }

        public int ResumeId { get; set; }
    }
}
