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
    public class MessageConfiguration : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.HasKey(m => m.Id);

            builder.Property(m => m.Content)
                .IsRequired()
                .HasColumnType("ntext");

            builder.HasOne(m => m.Candidate)
                .WithMany(c => c.Messages)
                .HasForeignKey(m => m.CandidateId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(m => m.Employer)
                .WithMany(e => e.Messages)
                .HasForeignKey(m => m.EmployerId)
                .OnDelete(DeleteBehavior.Restrict);
        }

    }
}
