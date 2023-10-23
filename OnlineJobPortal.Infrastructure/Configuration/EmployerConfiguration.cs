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
    public class EmployerConfiguration : IEntityTypeConfiguration<Employer>
    {
        public void Configure(EntityTypeBuilder<Employer> builder)
        {
            builder.HasKey(e => e.Id);

            // Configure properties
            builder.Property(e => e.FullName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.NationalId)
                .IsRequired(false)
                .HasMaxLength(20);

            builder.Property(e => e.Gender)
                .IsRequired();

            builder.Property(e => e.DateOfBirth)
                .IsRequired();

            builder.Property(e => e.Address)
                .HasMaxLength(200)
                .IsRequired(false);


            builder.Property(e => e.AvatarUrl)
                .HasMaxLength(255)
                .IsRequired(false);

            builder.Property(e => e.Position)
                .HasMaxLength(255)
                .IsRequired(false);

            builder.HasOne(e => e.User)
                .WithOne()
                .HasForeignKey<Employer>(e => e.UserId)
                .IsRequired();

            builder.HasMany(e => e.Messages)
                .WithOne(m => m.Employer)
                .HasForeignKey(m => m.EmployerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.Company)
                .WithMany(c => c.Employers)
                .HasForeignKey(e => e.CompanyId)
                .IsRequired();

            builder.HasMany(e => e.JobPosts)
                .WithOne(jp => jp.Employer)
                .HasForeignKey(jp => jp.EmployerId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
