using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Infrastructure.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions opt) : base(opt)
        {
            
        }

        public DbSet<Admin> Admins { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DbSet<Domain.Entities.Application> Applications { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DbSet<ApplicationUser> ApplicationUsers { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DbSet<CandidateSkill> BussinessIndustrys { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DbSet<Candidate> Candidates { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DbSet<CandidateSkill> CandidateSkills { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DbSet<Company> Companies { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DbSet<CompanyImage> CompanyImages { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DbSet<Education> Educations { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DbSet<Employer> Employers { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DbSet<Experience> Experiences { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DbSet<JobType> JobCategories { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DbSet<JobFavorite> JobFavorites { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DbSet<JobPost> JobPosts { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DbSet<RequirementSkill> JobRequirements { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DbSet<Message> Messages { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DbSet<Profile> Profiles { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DbSet<Skill> Skills { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            foreach (var entityType in builder.Model.GetEntityTypes())
            {
                var tableName = entityType.GetTableName();
                if(tableName.StartsWith("AspNet"))
                    entityType.SetTableName(tableName.Substring(6));
            }
        }

        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }
    }
}
