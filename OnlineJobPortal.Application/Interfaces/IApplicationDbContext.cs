﻿using Microsoft.EntityFrameworkCore;
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
        DbSet<OnlineJobPortal.Domain.Entities.Application> Applications { get; set; }
        DbSet<ApplicationUser> ApplicationUsers { get; set; }
        DbSet<BussinessIndustry> BussinessIndustrys { get; set; }
        DbSet<Candidate> Candidates { get; set; }
        DbSet<CandidateSkill> CandidateSkills { get; set; }
        DbSet<Company> Companies { get; set; }
        DbSet<CompanyImage> CompanyImages { get; set; }
        DbSet<Education> Educations { get; set; }
        DbSet<Employer> Employers { get; set; }
        DbSet<Experience> Experiences { get; set; }
        DbSet<JobCategory> JobCategories { get; set; }
        DbSet<JobFavorite> JobFavorites { get; set; }
        DbSet<JobPost> JobPosts { get; set; }
        DbSet<JobRequirement> JobRequirements { get; set; }
        DbSet<Message> Messages { get; set; }
        DbSet<Profile> Profiles { get; set; }
        DbSet<Skill> Skills { get; set; }

        Task<int> SaveChangesAsync();
    }
}