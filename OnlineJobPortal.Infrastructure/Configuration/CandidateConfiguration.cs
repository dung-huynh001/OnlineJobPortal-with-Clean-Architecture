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
    public class CandidateConfiguration : IEntityTypeConfiguration<Candidate>
    {
        public void Configure(EntityTypeBuilder<Candidate> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.FullName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(c => c.NationalId)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(c => c.Gender)
                .IsRequired();

            builder.Property(c => c.DateOfBirth)
                .IsRequired();

            builder.Property(c => c.Address)
                .HasMaxLength(200);

            builder.Property(c => c.AvatarUrl)
                .HasMaxLength(255);

            builder.HasOne(c => c.User)
                .WithOne()
                .HasForeignKey<Candidate>(c => c.UserId)
                .IsRequired();

            builder.HasMany(c => c.Applications)
                .WithOne(a => a.Candidate)
                .HasForeignKey(a => a.CandidateId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(c => c.JobFavorites)
                .WithOne(jf => jf.Candidate)
                .HasForeignKey(jf => jf.CandidateId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(c => c.Profiles)
                .WithOne(p => p.Candidate)
                .HasForeignKey(p => p.CandidateId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(c => c.Messages)
                .WithOne(m => m.Candidate)
                .HasForeignKey(m => m.CandidateId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
