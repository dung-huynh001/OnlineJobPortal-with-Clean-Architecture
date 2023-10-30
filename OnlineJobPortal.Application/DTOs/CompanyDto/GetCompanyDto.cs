using OnlineJobPortal.Application.DTOs.Common;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.DTOs.CompanyDto
{
    public class GetCompanyDto : BaseDto
    {
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string WebsiteUrl { get; set; }
        public string LogoUrl { get; set; }
    }
}
