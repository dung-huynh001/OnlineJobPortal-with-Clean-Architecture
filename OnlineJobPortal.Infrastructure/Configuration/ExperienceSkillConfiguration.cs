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
    public class ExperienceSkillConfiguration : IEntityTypeConfiguration<ExperienceSkill>
    {
        public void Configure(EntityTypeBuilder<ExperienceSkill> builder)
        {
            builder.HasKey(es => es.Id);

            builder.HasOne(es => es.Skill)
                .WithMany(s => s.ExperienceSkills)
                .HasForeignKey(es => es.SkillId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(es => es.Experience)
                .WithMany(e => e.ExperienceSkills)
                .HasForeignKey(cs => cs.ExperienceId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
