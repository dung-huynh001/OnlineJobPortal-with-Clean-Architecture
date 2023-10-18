using Microsoft.AspNetCore.Mvc;
using OnlineJobPortal.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Models.Identity
{
    public class RegistrationRequest
    {
		[Required(ErrorMessage = "Vui lòng nhập họ và tên.")]
		[BindProperty(Name = "RegistrationRequest.FullName")]
		public string FullName { get; set; }

		[Required]
		[BindProperty(Name = "RegistrationRequest.UserType")]
		public UserType UserType { get; set; }

        [Required(ErrorMessage ="Vui lòng nhập địa chỉ email.")]
        [EmailAddress(ErrorMessage = "Vui lòng nhập đúng định dạng email.")]
        [BindProperty(Name = "RegistrationRequest.Email")]
        public string Email { get; set; }

		[Required(ErrorMessage = "Vui lòng nhập mật khẩu.")]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Mật khẩu phải từ 6-50 ký tự.")]
		[BindProperty(Name = "RegistrationRequest.Password")]
		public string Password { get; set; }

		[Required(ErrorMessage = "Vui lòng nhập lại mật khẩu.")]
		[BindProperty(Name = "RegistrationRequest.PasswordConfirm")]
		[StringLength(50, MinimumLength = 6, ErrorMessage = "Mật khẩu phải từ 6-50 ký tự.")]
		public string PasswordConfirm { get; set; }
    }
}
