using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Models.Identity
{

    public class AuthRequest
    {
        [Required(ErrorMessage = "Vui lòng nhập địa chỉ email.")]
        [EmailAddress(ErrorMessage = "Vui lòng nhập đúng định dạng email.")]
        [BindProperty(Name = "AuthRequest.Email")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Vui lòng nhập password.")]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Mật khẩu phải từ 6-50 ký tự.")]
		[BindProperty(Name = "AuthRequest.Password")]
		public string Password { get; set; }
    }
}
