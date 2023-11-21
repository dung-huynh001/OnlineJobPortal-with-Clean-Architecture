using OnlineJobPortal.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.DTOs.ForeignLanguageDto
{
    public class GetForeignLanguageDto : BaseDto
    {
        public string LanguageName { get; set; }
        public string Degree { get; set; }
    }
}
