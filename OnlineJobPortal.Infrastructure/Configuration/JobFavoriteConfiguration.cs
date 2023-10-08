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
    public class JobFavoriteConfiguration : IEntityTypeConfiguration<JobFavorite>
    {
        public void Configure(EntityTypeBuilder<JobFavorite> builder)
        {
            builder.HasKey(jf => jf.Id);

            builder.Property(jf => jf.Star)
                .IsRequired();

            builder.HasOne(jf => jf.Candidate)
                .WithMany(c => c.JobFavorites)
                .HasForeignKey(jf => jf.CandidateId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(jf => jf.JobPost)
                .WithMany(jp => jp.JobFavorites)
                .HasForeignKey(jf => jf.JobPostId)
                .OnDelete(DeleteBehavior.Restrict);
        }

    }
}
