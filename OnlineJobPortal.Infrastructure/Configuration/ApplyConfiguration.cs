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
    public class ApplyConfiguration : IEntityTypeConfiguration<Apply>
    {
        public void Configure(EntityTypeBuilder<Apply> builder)
        {
            builder.HasKey(e => e.Id);


            builder.Property(e => e.Status)
                .IsRequired(false);

            builder.Property(e => e.CoverLetter)
                .HasColumnType("ntext")
                .IsRequired(false);

            builder.Property(e => e.CvUrl)
                .IsRequired(false);

            builder.HasOne<Candidate>(e => e.Candidate)
                .WithOne()
                .IsRequired()
                .HasForeignKey<Apply>(a => a.CandidateId);
            builder.HasOne<JobPost>(e => e.JobPost)
                .WithOne()
                .IsRequired()
                .HasForeignKey<Apply>(a => a.JobPostId);
        }
    }
}
