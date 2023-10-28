using OnlineJobPortal.Application.DTOs.Common;
using OnlineJobPortal.Domain.Entities;
using OnlineJobPortal.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.DTOs.JobPostDto
{
    public class GetJobPostWithPaginationDto : BaseDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string EmploymentType { get; set; }
        public string Salary { get; set; }
        public string Province { get; set; }
        public DateTime ExpiredDate { get; set; }
        public List<string> Skills { get; set; }
        public int EmployerId { get; set; }
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
    }
}
