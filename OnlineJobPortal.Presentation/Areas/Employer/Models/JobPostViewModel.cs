using OnlineJobPortal.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace OnlineJobPortal.Presentation.Areas.Employer.Models
{
    public class JobPostViewModel
    {
        [Required(ErrorMessage = "The Title field is required.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "The Category field is required.")]
        public int JobTypeId { get; set; }

        [Required(ErrorMessage = "The Employment Type field is required.")]
        public EmploymentType EmploymentType { get; set; }

        [Required(ErrorMessage = "The Level field is required.")]
        public Level Level { get; set; }

        [Required(ErrorMessage = "The Years Of Experience field is required.")]
        public string YearsOfExperience { get; set; }

        [Required(ErrorMessage = "The Number Of Recruits field is required.")]
        public int NumberOfRecruits { get; set; }

        [Required(ErrorMessage = "The Province field is required.")]
        public int ProvinceId { get; set; }

        [Required(ErrorMessage = "The Province Name field is required.")]
        public string ProvinceName { get; set; }

        [Required(ErrorMessage = "The District field is required.")]
        public int DistrictId { get; set; }

        [Required(ErrorMessage = "The District Name field is required.")]
        public string DistrictName { get; set; }

        [Required(ErrorMessage = "The Address field is required.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "The Expired Date field is required.")]
        public DateTime ExpiredDate { get; set; }

        [Required(ErrorMessage = "The Description field is required.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "The Requirement field is required.")]
        public string Requirement { get; set; }

        [Required(ErrorMessage = "The Salary field is required.")]
        public string Salary { get; set; }

        [Required(ErrorMessage = "The Benefits field is required.")]
        public string Benefits { get; set; }

        [Required(ErrorMessage = "The Skills field is required.")]
        public List<SkillViewModel> Skills { get; set; }
    }
}
