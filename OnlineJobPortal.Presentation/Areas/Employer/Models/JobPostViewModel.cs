using OnlineJobPortal.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace OnlineJobPortal.Presentation.Areas.Employer.Models
{
    public class JobPostViewModel
    {
        public string Title { get; set; }
        public int JobTypeId { get; set; }
        public Level Level { get; set; }
        public string YearsOfExperience { get; set; }
        public int NumberOfRecruits { get; set; }
        public int ProvinceId { get; set; }
        public string ProvinceName { get; set; }
        public int DistrictId { get; set; }
        public string DistrictName { get; set; }
        public string Address { get; set; }
        public DateTime ExpiredDate { get; set; }
        public string Description { get; set; }
        public string Requirement { get; set; }
        public string Salary { get; set; }
        public string Benefits { get; set; }
        [Required]
        public List<SkillViewModel> Skills { get; set; }
    }
}
