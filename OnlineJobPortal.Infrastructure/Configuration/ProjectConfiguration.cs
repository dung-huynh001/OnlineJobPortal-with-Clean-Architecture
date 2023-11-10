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
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Title)
                .IsRequired();
            builder.Property(p => p.Description)
                .HasColumnType("ntext")
                .IsRequired(false);
            builder.Property(p => p.LinkGit)
                .IsRequired(false);
            builder.Property(p => p.Position)
                .IsRequired();
            builder.HasOne(p => p.Resume)
                .WithMany(r => r.Project)
                .HasForeignKey(r => r.ResumeId);
        }
    }
}
