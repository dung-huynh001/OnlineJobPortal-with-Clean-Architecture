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
    public class SkillConfiguration : IEntityTypeConfiguration<Skill>
    {
        public void Configure(EntityTypeBuilder<Skill> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(s => s.SkillName)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasMany(s => s.CandidateSkills)
                .WithOne(cs => cs.Skill)
                .HasForeignKey(cs => cs.SkillId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(s => s.RequirementSkills)
                .WithOne(rs => rs.Skill)
                .HasForeignKey(rs => rs.SkillId)
                .OnDelete(DeleteBehavior.Restrict);
        }

    }
}
