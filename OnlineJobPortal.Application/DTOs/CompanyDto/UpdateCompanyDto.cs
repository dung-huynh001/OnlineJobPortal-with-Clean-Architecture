using Microsoft.AspNetCore.Http;
using OnlineJobPortal.Application.DTOs.Common;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.DTOs.CompanyDto
{
    public class UpdateCompanyDto : BaseDto
    {
        public string CompanyName { get; set; }
        public string Owner { get; set; }
        public DateTime EstablishmentDate { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public string Hotline { get; set; }
        public string? Facebook { get; set; }
        public string? Twitter { get; set; }
        public string? WebsiteUrl { get; set; }
        public string LogoUrl { get; set; }
        public int DistrictId { get; set; }
        public int ProvinceId { get; set; }
        public int? BussinessIndustryId { get; set; }
    }
}
