using OnlineJobPortal.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace OnlineJobPortal.Presentation.Areas.Employer.Models
{
    public class CompanyProfileViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tên công ty")]
        public string CompanyName { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tên chủ doanh nghiệp")]
        public string Owner { get; set; }
        public DateTime EstablishmentDate { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập địa chỉ")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập địa chỉ Email")]
        [EmailAddress(ErrorMessage = "Vui lòng nhập đúng định dạng Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập thông tin mô tả công ty")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập số điện thoại")]
        [MaxLength(10)]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0][0-9]{2})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string Hotline { get; set; }
        public string? Facebook { get; set; }
        public string? Twitter { get; set; }
        public string? WebsiteUrl { get; set; }
        public string? LogoUrl { get; set; }
        [Required(ErrorMessage = "Vui lòng chọn quận/huyện")]
        public int DistrictId { get; set; }
        [Required(ErrorMessage = "Vui lòng chọn tỉnh/thành phố")]
        public string DistrictName { get; set; }
        public int ProvinceId { get; set; }
        [Required(ErrorMessage = "Vui lòng chọn lĩnh vực kinh doanh")]
        public string ProvinceName { get; set; }
        public int? BussinessIndustryId { get; set; }
        public IFormFile? CompanyLogo { get; set; }
    }
}
