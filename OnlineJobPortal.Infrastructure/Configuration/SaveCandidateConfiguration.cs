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
    public class SaveCandidateConfiguration : IEntityTypeConfiguration<SaveCandidate>
    {
        public void Configure(EntityTypeBuilder<SaveCandidate> builder)
        {
            builder.HasKey(sc => sc.Id);

            builder.HasOne(sc => sc.Candidate)
                .WithMany(c => c.SaveCandidates)
                .HasForeignKey(sc => sc.CandidateId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(sc => sc.Company)
                .WithMany(c => c.SaveCandidates)
                .HasForeignKey(sc => sc.CompanyId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
