using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.DTOs.JobPostDto
{
    public class CreateJobPostDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Requirement { get; set; }
        public string Location { get; set; }
        public string Salary { get; set; }
        public string Address { get; set; }
        public int NumberOfRecruits { get; set; }
        public DateTime ExpiredDate { get; set; }
        public int EmployerId { get; set; }
        public int JobTypeId { get; set; }
    }
}
