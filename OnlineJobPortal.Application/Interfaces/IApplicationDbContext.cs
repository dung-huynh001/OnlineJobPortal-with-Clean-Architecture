using Microsoft.EntityFrameworkCore;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace OnlineJobPortal.Application.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Admin> Admins { get; set; }
        DbSet<Apply> Applys { get; set; }
        DbSet<ApplicationUser> ApplicationUsers { get; set; }
        DbSet<BussinessIndustry> BussinessIndustrys { get; set; }
        DbSet<Candidate> Candidates { get; set; }
        DbSet<CandidateSkill> CandidateSkills { get; set; }
        DbSet<Company> Companies { get; set; }
        DbSet<CompanyImage> CompanyImages { get; set; }
        DbSet<Education> Educations { get; set; }
        DbSet<Employer> Employers { get; set; }
        DbSet<Experience> Experiences { get; set; }
        DbSet<JobType> JobTypes { get; set; }
        DbSet<JobFavorite> JobFavorites { get; set; }
        DbSet<JobPost> JobPosts { get; set; }
        DbSet<RequirementSkill> RequirementSkills { get; set; }
        DbSet<Message> Messages { get; set; }
        DbSet<Resume> Resumes { get; set; }
        DbSet<Skill> Skills { get; set; }

        Task<int> SaveChangesAsync(); 
        Task<int> SaveChangesAsync(CancellationToken cancellation);
    }
}
