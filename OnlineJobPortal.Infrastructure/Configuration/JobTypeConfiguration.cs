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
    public class JobTypeConfiguration : IEntityTypeConfiguration<JobType>
    {
        public void Configure(EntityTypeBuilder<JobType> builder)
        {
            builder.HasKey(jt => jt.Id);

            builder.Property(jt => jt.JobTypeName)
                .IsRequired()
                .HasMaxLength(256);

            builder.Property(jt => jt.JobTypeIcon)
                .IsRequired()
                .HasMaxLength(256);

            builder.HasMany(jt => jt.JobPost)
                .WithOne(jp => jp.JobType)
                .HasForeignKey(jp => jp.JobTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            var jobTypes = new List<JobType>
            {
                new JobType { Id = 1, JobTypeName = "Web Developer", JobTypeIcon = "fa-laptop-code" },
                new JobType { Id = 2, JobTypeName = "Mobile Developer", JobTypeIcon = "fa-mobile-alt" },
                new JobType { Id = 3, JobTypeName = "QA & QC", JobTypeIcon = "fa-check-double" },
                new JobType { Id = 4, JobTypeName = "Business Analysis", JobTypeIcon = "fa-chart-pie" },
                new JobType { Id = 5, JobTypeName = "Tester", JobTypeIcon = "fa-user-shield" },
                new JobType { Id = 6, JobTypeName = "Internet of things(IoT)", JobTypeIcon = "fa-wifi" },
                new JobType { Id = 7, JobTypeName = "Project Management", JobTypeIcon = "fa-tasks" },
                new JobType { Id = 8, JobTypeName = "Human Resource", JobTypeIcon = "fa-users" },
                new JobType { Id = 9, JobTypeName = "Design & Creative", JobTypeIcon = "fa-paint-brush" },
                new JobType { Id = 10, JobTypeName = "System Admin", JobTypeIcon = "fa-server" },
                new JobType { Id = 11, JobTypeName = "DevOps", JobTypeIcon = "fa-cogs" },
                new JobType { Id = 12, JobTypeName = "System Security", JobTypeIcon = "fa-shield-alt" }
            };
            builder.HasData(jobTypes);
        }

    }
}
