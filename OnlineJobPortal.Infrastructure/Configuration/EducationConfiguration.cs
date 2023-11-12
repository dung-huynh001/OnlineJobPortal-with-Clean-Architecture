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
    public class EducationConfiguration : IEntityTypeConfiguration<Education>
    {
        public void Configure(EntityTypeBuilder<Education> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Major)
                .IsRequired()
                .HasMaxLength(256);

            builder.Property(e => e.University)
                .IsRequired()
                .HasMaxLength(256);

            builder.Property(e => e.StartDate)
                .HasColumnType("Date")
                .IsRequired();

            builder.Property(e => e.CompletionDate)
                .HasColumnType("Date")
                .IsRequired();

            builder.Property(e => e.GPA)
                .IsRequired();

            builder.HasOne(e => e.Resume)
                .WithMany(p => p.Educations)
                .HasForeignKey(e => e.ResumeId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
