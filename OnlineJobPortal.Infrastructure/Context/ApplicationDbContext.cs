using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Domain.Common;
using OnlineJobPortal.Domain.Entities;
using OnlineJobPortal.Infrastructure.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Infrastructure.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions opt) : base(opt)
        {
            
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Apply> Applys { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<BussinessIndustry> BussinessIndustrys { get; set; }
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<CandidateSkill> CandidateSkills { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanyImage> CompanyImages { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Employer> Employers { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<JobType> JobTypes { get; set; }
        public DbSet<JobFavorite> JobFavorites { get; set; }
        public DbSet<JobPost> JobPosts { get; set; }
        public DbSet<RequirementSkill> RequirementSkills { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Resume> Resumes { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Project> Projects { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            foreach (var entityType in builder.Model.GetEntityTypes())
            {
                var tableName = entityType.GetTableName();
                if(tableName.StartsWith("AspNet"))
                    entityType.SetTableName(tableName.Substring(6));
            }

            builder.ApplyConfiguration(new AdminConfiguration());
            builder.ApplyConfiguration(new ApplyConfiguration());
            builder.ApplyConfiguration(new BussinessIndustryConfiguration());
            builder.ApplyConfiguration(new CandidateConfiguration());
            builder.ApplyConfiguration(new CandidateSkillConfiguration());
            builder.ApplyConfiguration(new CompanyConfiguration());
            builder.ApplyConfiguration(new CompanyImageConfiguration());
            builder.ApplyConfiguration(new EducationConfiguration());
            builder.ApplyConfiguration(new EmployerConfiguration());
            builder.ApplyConfiguration(new ExperienceConfiguration());
            builder.ApplyConfiguration(new ForeignLanguageConfiguration());
            builder.ApplyConfiguration(new JobFavoriteConfiguration());
            builder.ApplyConfiguration(new JobPostConfiguration());
            builder.ApplyConfiguration(new JobTypeConfiguration());
            builder.ApplyConfiguration(new MessageConfiguration());
            builder.ApplyConfiguration(new ResumeConfiguration());
            builder.ApplyConfiguration(new RequirementSkillConfiguration());
            builder.ApplyConfiguration(new SkillConfiguration());
            builder.ApplyConfiguration(new ProvinceConfiguration());
            builder.ApplyConfiguration(new DistrictConfiguration());
            builder.ApplyConfiguration(new ProjectConfiguration());
        }

        public virtual async Task<int> SaveChangesAsync()
        {
            foreach (var entity in base.ChangeTracker.Entries<BaseEntity>()
                .Where(q => q.State == EntityState.Added || q.State == EntityState.Modified))
            {
                entity.Entity.UpdateAt = DateTime.Now;

                if(entity.State == EntityState.Added)
                    entity.Entity.CreateAt = DateTime.Now;
            }

            return await base.SaveChangesAsync();
        }

        public virtual async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            foreach (var entity in base.ChangeTracker.Entries<BaseEntity>()
                .Where(q => q.State == EntityState.Added || q.State == EntityState.Modified))
            {
                entity.Entity.UpdateAt = DateTime.Now;

                if (entity.State == EntityState.Added)
                    entity.Entity.CreateAt = DateTime.Now;
            }

            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
