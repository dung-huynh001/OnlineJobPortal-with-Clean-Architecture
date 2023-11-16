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
                .IsRequired(false)
                .HasMaxLength(20);

            builder.Property(c => c.Gender)
                .IsRequired();

            builder.Property(c => c.DateOfBirth)
                .HasColumnType("Date")
                .IsRequired();

            builder.Property(c => c.Address)
                .HasMaxLength(200)
                .IsRequired(false);

            builder.Property(c => c.AvatarUrl)
                .HasMaxLength(255)
                .IsRequired(false);

            builder.HasOne(c => c.User)
                .WithOne()
                .HasForeignKey<Candidate>(c => c.UserId)
                .IsRequired();

            builder.HasOne(c => c.Resume)
                .WithOne()
                .HasForeignKey<Candidate>(c => c.ResumeId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Cascade);


            builder.HasMany(c => c.Applies)
                .WithOne(a => a.Candidate)
                .HasForeignKey(a => a.CandidateId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(c => c.JobFavorites)
                .WithOne(jf => jf.Candidate)
                .HasForeignKey(jf => jf.CandidateId)
                .OnDelete(DeleteBehavior.Cascade);

            /*builder.HasMany(c => c.Messages)
                .WithOne(m => m.Candidate)
                .HasForeignKey(m => m.CandidateId)
                .OnDelete(DeleteBehavior.Cascade);*/
        }
    }
}
