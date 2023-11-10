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
    public class ExperienceProjectConfiguration : IEntityTypeConfiguration<ExperienceProject>
    {
        public void Configure(EntityTypeBuilder<ExperienceProject> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Title)
                .IsRequired();
            builder.Property(e => e.Position)
                .IsRequired();
        }
    }
}
