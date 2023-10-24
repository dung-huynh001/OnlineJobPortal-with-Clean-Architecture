using OnlineJobPortal.Domain.Entities;
using OnlineJobPortal.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.DTOs.EmployerDto
{
    public class CreateEmployerDto
    {
        //Employer Info
        public string FullName { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string UserId { get; set; }
        public int CompanyId { get; set; }
        public Position Position { get; set; }
        
        //Company Info
        public int DistrictId { get; set; }
        public int ProvinceId { get; set; }
        public string CompanyName { get; set; }
        public string WebsiteUrl { get; set; }
        public string Address { get; set; }
    }
}
