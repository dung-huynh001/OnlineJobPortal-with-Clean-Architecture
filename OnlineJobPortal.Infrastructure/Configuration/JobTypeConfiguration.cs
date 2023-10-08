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
        }

    }
}
