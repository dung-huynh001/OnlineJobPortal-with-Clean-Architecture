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
    public class ExperienceConfiguration : IEntityTypeConfiguration<Experience>
    {
        public void Configure(EntityTypeBuilder<Experience> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Position)
                .IsRequired(false)
                .HasMaxLength(256);

            builder.Property(e => e.CompanyName)
                .IsRequired(false)
                .HasMaxLength(100);

            builder.Property(e => e.Description)
                .HasColumnType("ntext")
                .IsRequired(false);

            builder.HasOne(e => e.Resume)
                .WithMany(p => p.Experiences)
                .HasForeignKey(e => e.ResumeId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(e => e.ExperienceProjects)
                .WithOne(p => p.Experience)
                .HasForeignKey(e => e.ExperienceId)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired(false);
        }
    }
}
