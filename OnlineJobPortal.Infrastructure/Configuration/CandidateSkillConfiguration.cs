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
    public class CandidateSkillConfiguration : IEntityTypeConfiguration<CandidateSkill>
    {
        public void Configure(EntityTypeBuilder<CandidateSkill> builder)
        {
            builder.HasKey(cs => cs.Id);

            builder.Property(cs => cs.Level)
                .IsRequired();

            builder.HasOne(cs => cs.Resume)
                .WithMany(p => p.CandidateSkills)
                .HasForeignKey(cs => cs.ResumeId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(cs => cs.Skill)
                .WithMany()
                .HasForeignKey(cs => cs.SkillId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
