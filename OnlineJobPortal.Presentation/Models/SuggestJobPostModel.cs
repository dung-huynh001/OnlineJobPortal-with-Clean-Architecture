

using Microsoft.AspNetCore.Mvc;
using OnlineJobPortal.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

namespace OnlineJobPortal.Presentation.Models
{
    public class SuggestJobPostModel
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string DistrictName { get; set; }
        public int EmployerId { get; set; }
        public int EmploymentType { get; set; }
        public DateTime ExpiredDate { get; set; }
        public int JobPostId { get; set; }
        public string LogoUrl { get; set; }
        public string ProvinceName { get; set; }
        public string Salary { get; set; }
        public List<string> skills { get; set; }
        public string Title { get; set; }
        public string YearsOfExperience { get; set; }
        public bool Saved { get; set; } = false;
    }

}
