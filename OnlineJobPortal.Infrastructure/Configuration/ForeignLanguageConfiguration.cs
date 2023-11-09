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
    public class ForeignLanguageConfiguration : IEntityTypeConfiguration<ForeignLanguage>
    {
        public void Configure(EntityTypeBuilder<ForeignLanguage> builder)
        {
            builder.HasKey(fl => fl.Id);

            builder.Property(fl => fl.LanguageName)
                .IsRequired()
                .HasMaxLength(256);

            builder.Property(fl => fl.Degree)
                .HasMaxLength(256);

            builder.HasOne(fl => fl.Resume)
                .WithMany(p => p.ForeignLanguages)
                .HasForeignKey(fl => fl.ResumeId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
