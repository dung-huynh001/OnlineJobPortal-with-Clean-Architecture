using OnlineJobPortal.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.DTOs.CompanyDto
{
    public class CreateCompanyDto : BaseDto
    {
        public int DistrictId { get; set; }
        public int ProvinceId { get; set; }
        public string LogoUrl { get; set; }
        public string CompanyName { get; set; }
        public string WebsiteUrl { get; set; }
        public string Address { get; set; }
    }
}
