using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Infrastructure.Configuration
{
    public class JobPostConfiguration : IEntityTypeConfiguration<JobPost>
    {
        public void Configure(EntityTypeBuilder<JobPost> builder)
        {
            builder.HasKey(jp => jp.Id);

            builder.Property(jp => jp.Title)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(jp => jp.Description)
                .IsRequired()
                .HasColumnType("ntext");

            builder.Property(jp => jp.Requirement)
                .HasColumnType("ntext");

            builder.Property(jp => jp.Benefits)
                .HasColumnType("ntext");

            builder.Property(jp => jp.ProvinceId)
                .IsRequired();
            builder.Property(jp => jp.DistrictId)
                .IsRequired();

            builder.Property(jp => jp.Salary)
                .HasMaxLength(256);

            builder.Property(jp => jp.Address)
                .HasMaxLength(256);

            builder.Property(jp => jp.YearsOfExperience)
                .HasMaxLength(256);

            builder.Property(jp => jp.NumberOfRecruits)
                .IsRequired();

            builder.Property(jp => jp.ExpiredDate)
                .HasColumnType("Date")
                .IsRequired();

            builder.HasMany(jp => jp.RequirementSkills)
                .WithOne(rs => rs.JobPost)
                .HasForeignKey(rs => rs.JobPostId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(jp => jp.JobFavorites)
                .WithOne(jf => jf.JobPost)
                .HasForeignKey(jf => jf.JobPostId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(jp => jp.Applications)
                .WithOne(a => a.JobPost)
                .HasForeignKey(a => a.JobPostId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(jp => jp.Employer)
                .WithMany(e => e.JobPosts)
                .HasForeignKey(jp => jp.EmployerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(jp => jp.JobType)
                .WithMany()
                .HasForeignKey(jp => jp.JobTypeId)
                .IsRequired();
        }

    }
}
