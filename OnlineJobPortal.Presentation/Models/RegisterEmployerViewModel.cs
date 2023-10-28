using Microsoft.AspNetCore.Mvc;
using OnlineJobPortal.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace OnlineJobPortal.Presentation.Models
{
    public class RegisterEmployerViewModel
    {
        // Employer Info
        public string Email { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public UserType UserType { get; set; }
        public Position Position { get; set; }

        // Company Info
        public string CompanyName { get; set; }
        public string WebsiteUrl { get; set; }
        public int ProvinceId { get; set; }
        public string ProvinceName { get; set; }
        public int DistrictId { get; set; }
        public string DistrictName { get; set; }
        public string Address { get; set; }
        public string? LogoUrl { get; set; }
        [BindProperty]
        public IFormFile CompanyLogo { get; set; }
    }
}
