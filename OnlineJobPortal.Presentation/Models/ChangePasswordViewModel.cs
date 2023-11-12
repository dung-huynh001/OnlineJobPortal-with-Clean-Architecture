using System.ComponentModel.DataAnnotations;

namespace OnlineJobPortal.Presentation.Models
{
    public class ChangePasswordViewModel
    {
        [Required(ErrorMessage = "Vui lòng nhập mật khẩu hiện tại")]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Mật khẩu phải từ 6-50 ký tự.")]
        public string CurrentPassword { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập mật khẩu mới")]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Mật khẩu phải từ 6-50 ký tự.")]
        public string NewPassword { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập lại mật khẩu")]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Mật khẩu phải từ 6-50 ký tự.")]
        [Compare(nameof(NewPassword), ErrorMessage = "Mật khẩu nhập lại không trùng khớp")]
        public string ConfirmPassword { get; set;}
    }
}
