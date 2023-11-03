using OnlineJobPortal.Application.DTOs.RequirementSkillDto;
using OnlineJobPortal.Application.DTOs.SkillDto;
using OnlineJobPortal.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace OnlineJobPortal.Presentation.Areas.Employer.Models
{
    public class JobPostViewModel
    {
        [Required(ErrorMessage = "Vui lòng nhập tiêu đề")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn danh mục")]
        public int? JobTypeId { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn hình thức làm việc")]
        public EmploymentType? EmploymentType { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn trình độ")]
        public Level? Level { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập số năm kinh nghiệm")]
        public string? YearsOfExperience { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập số lượng tuyển dụng")]
        public int? NumberOfRecruits { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn tỉnh/thành phố")]
        public int? ProvinceId { get; set; }

        [Required]
        public string? ProvinceName { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn quận/huyện")]
        public int? DistrictId { get; set; }

        [Required]
        public string? DistrictName { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập địa chỉ")]
        public string? Address { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn thời gian hết hạn")]
        public DateTime? ExpiredDate { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập mô tả chi tiết")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập yêu cầu ứng viên")]
        public string? Requirement { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập thông tin lương")]
        public string? Salary { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập quyền lợi")]
        public string? Benefits { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn các kỹ năng yêu cầu")]
        public List<CreateRequirementSkillDto> Skills { get; set; }
        public int? EmployerId { get; set; }
    }
}
