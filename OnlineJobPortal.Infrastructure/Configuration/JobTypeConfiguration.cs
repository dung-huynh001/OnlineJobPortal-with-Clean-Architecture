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
                .HasMaxLength(100);

            builder.HasMany(jt => jt.JobPost)
                .WithOne(jp => jp.JobType)
                .HasForeignKey(jp => jp.JobTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            var jobTypes = new List<JobType>
            {
                new JobType { Id = 1, JobTypeName = "Web Developer" },
                new JobType { Id = 2, JobTypeName = "Mobile Developer" },
                new JobType { Id = 3, JobTypeName = "QA & QC" },
                new JobType { Id = 4, JobTypeName = "Business Analysis" },
                new JobType { Id = 5, JobTypeName = "Tester" },
                new JobType { Id = 6, JobTypeName = "Designer" },
                new JobType { Id = 7, JobTypeName = "Project Management" },
                new JobType { Id = 8, JobTypeName = "Human Resource" },
                new JobType { Id = 9, JobTypeName = "Design & Creative" },
                new JobType { Id = 10, JobTypeName = "System Admin" },
                new JobType { Id = 11, JobTypeName = "DevOps" },
                new JobType { Id = 12, JobTypeName = "System Security" }
            };
            builder.HasData(jobTypes);
        }

    }
}
