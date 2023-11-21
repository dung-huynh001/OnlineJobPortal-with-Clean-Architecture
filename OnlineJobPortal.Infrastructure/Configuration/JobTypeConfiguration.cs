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
                new JobType { Id = 1, JobTypeName = "Web Developer", JobTypeIcon = "fa-laptop-code", CreateAt = DateTime.Now, UpdateAt = DateTime.Now },
                new JobType { Id = 2, JobTypeName = "Mobile Developer", JobTypeIcon = "fa-mobile-alt", CreateAt = DateTime.Now, UpdateAt = DateTime.Now },
                new JobType { Id = 3, JobTypeName = "QA & QC", JobTypeIcon = "fa-check-double", CreateAt = DateTime.Now, UpdateAt = DateTime.Now },
                new JobType { Id = 4, JobTypeName = "Business Analysis", JobTypeIcon = "fa-chart-pie", CreateAt = DateTime.Now, UpdateAt = DateTime.Now },
                new JobType { Id = 5, JobTypeName = "Tester", JobTypeIcon = "fa-user-shield", CreateAt = DateTime.Now, UpdateAt = DateTime.Now },
                new JobType { Id = 6, JobTypeName = "Internet of things(IoT)", JobTypeIcon = "fa-wifi", CreateAt = DateTime.Now, UpdateAt = DateTime.Now },
                new JobType { Id = 7, JobTypeName = "Project Management", JobTypeIcon = "fa-tasks", CreateAt = DateTime.Now, UpdateAt = DateTime.Now },
                new JobType { Id = 8, JobTypeName = "Human Resource", JobTypeIcon = "fa-users", CreateAt = DateTime.Now, UpdateAt = DateTime.Now },
                new JobType { Id = 9, JobTypeName = "Design & Creative", JobTypeIcon = "fa-paint-brush", CreateAt = DateTime.Now, UpdateAt = DateTime.Now },
                new JobType { Id = 10, JobTypeName = "System Admin", JobTypeIcon = "fa-server", CreateAt = DateTime.Now, UpdateAt = DateTime.Now },
                new JobType { Id = 11, JobTypeName = "DevOps", JobTypeIcon = "fa-cogs", CreateAt = DateTime.Now, UpdateAt = DateTime.Now },
                new JobType { Id = 12, JobTypeName = "System Security", JobTypeIcon = "fa-shield-alt", CreateAt = DateTime.Now, UpdateAt = DateTime.Now },
                new JobType { Id = 13, JobTypeName = "IT Support", JobTypeIcon = "fa-headset", CreateAt = DateTime.Now, UpdateAt = DateTime.Now },
                new JobType { Id = 14, JobTypeName = "IT Helpdesk", JobTypeIcon = "fa-circle-question", CreateAt = DateTime.Now, UpdateAt = DateTime.Now},
                new JobType { Id = 15, JobTypeName = "Frontend Developer", JobTypeIcon = "fa-code", CreateAt = DateTime.Now, UpdateAt = DateTime.Now },
                new JobType { Id = 16, JobTypeName = "Backend Developer", JobTypeIcon = "fa-database", CreateAt = DateTime.Now, UpdateAt = DateTime.Now },
                new JobType { Id = 17, JobTypeName = "Fullstack Developer", JobTypeIcon = "fa-layer-group", CreateAt = DateTime.Now, UpdateAt = DateTime.Now },
            };
            builder.HasData(jobTypes);
        }

    }
}
