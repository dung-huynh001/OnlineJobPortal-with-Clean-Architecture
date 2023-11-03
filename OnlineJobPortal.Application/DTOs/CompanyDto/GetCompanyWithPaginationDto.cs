using OnlineJobPortal.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.DTOs.CompanyDto
{
    public class GetCompanyWithPaginationDto : BaseDto
    {
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string LogoUrl { get; set; }
        public int TotalJob { get; set; }
    }
}
