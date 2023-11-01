using Microsoft.AspNetCore.Mvc;
using OnlineJobPortal.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

namespace OnlineJobPortal.Presentation.Models
{
    public class RegisterEmployerViewModel
    {
        // Employer Info
        [Required(ErrorMessage = "Vui lòng nhập địa chỉ email")]
        [EmailAddress(ErrorMessage = "Vui lòng nhập đúng định dạng email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập mật khẩu")]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Mật khẩu phải từ 6 - 50 ký tự")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập lại mật khẩu")]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Mật khẩu phải từ 6 - 50 ký tự")]
        public string PasswordConfirm { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập họ và tên")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập số điện thoại")]
        public string PhoneNumber { get; set; }
        public UserType UserType { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập chức vụ")]
        public Position Position { get; set; }

        // Company Info
        [Required(ErrorMessage = "Vui lòng nhập tên công ty")]
        public string CompanyName { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập website công ty")]
        public string WebsiteUrl { get; set; }
        [Required(ErrorMessage = "Vui lòng chọn tỉnh/thành phố")]
        public int ProvinceId { get; set; }
        public string ProvinceName { get; set; }
        [Required(ErrorMessage = "Vui lòng chọn quận/huyện")]
        public int DistrictId { get; set; }
        public string DistrictName { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập địa chỉ")]
        public string Address { get; set; }

        public string? LogoUrl { get; set; }
        [BindProperty]
        [Required(ErrorMessage = "Vui lòng chọn logo công ty")]
        public IFormFile CompanyLogo { get; set; }
    }
}
