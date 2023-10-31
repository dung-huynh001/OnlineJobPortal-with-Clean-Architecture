using OnlineJobPortal.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace OnlineJobPortal.Presentation.Areas.Employer.Models
{
    public class CompanyProfileViewModel
    {
        public int Id { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required]
        public string Owner { get; set; }
        [Required]
        public DateTime EstablishmentDate { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Hotline { get; set; }
        public string? Facebook { get; set; }
        public string? Twitter { get; set; }
        [Required]
        public string? WebsiteUrl { get; set; }
        public string LogoUrl { get; set; }
        [Required]
        public int DistrictId { get; set; }
        [Required]
        public int ProvinceId { get; set; }
        public District District { get; set; }
        [Required]
        public int? BussinessIndustryId { get; set; }
        public BussinessIndustry? BussinessIndustry { get; set; }
        public IFormFile? CompanyLogo { get; set; }
    }
}
