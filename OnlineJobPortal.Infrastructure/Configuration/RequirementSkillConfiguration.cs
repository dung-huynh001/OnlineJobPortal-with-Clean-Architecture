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
    public class RequirementSkillConfiguration : IEntityTypeConfiguration<RequirementSkill>
    {
        public void Configure(EntityTypeBuilder<RequirementSkill> builder)
        {
            builder.HasKey(rs => rs.Id);

            builder.Property(rs => rs.Level)
                .IsRequired();

            builder.HasOne(rs => rs.JobPost)
                .WithMany(jp => jp.RequirementSkills)
                .HasForeignKey(rs => rs.JobPostId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(rs => rs.Skill)
                .WithMany()
                .HasForeignKey(rs => rs.SkillId)
                .OnDelete(DeleteBehavior.Restrict);
        }

    }
}
