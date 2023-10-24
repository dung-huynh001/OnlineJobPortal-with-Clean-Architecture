using Microsoft.AspNetCore.Mvc;
using OnlineJobPortal.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Models.Identity
{
    public class RegistrationEmployerRequest
    {
        [Required(ErrorMessage = "Vui lòng nhập họ và tên.")]
        public string FullName { get; set; }

        [Required]
        public UserType UserType { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập địa chỉ email.")]
        [EmailAddress(ErrorMessage = "Vui lòng nhập đúng định dạng email.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập mật khẩu.")]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Mật khẩu phải từ 6-50 ký tự.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập lại mật khẩu.")]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Mật khẩu phải từ 6-50 ký tự.")]
        public string PasswordConfirm { get; set; }
        public Position Position { get; set; }
        public int CompanyId { get; set; }

        //Company Info
        public int DistrictId { get; set; }
        public int ProvinceId { get; set; }
        public string CompanyName { get; set; }
        public string WebsiteUrl { get; set; }
        public string Address { get; set; }
    }
}
