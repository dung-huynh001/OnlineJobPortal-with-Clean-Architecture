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
                .HasMaxLength(100);

            builder.Property(fl => fl.Proficiency)
                .HasMaxLength(50);

            builder.Property(fl => fl.Degree)
                .HasMaxLength(50);

            builder.HasOne(fl => fl.Profile)
                .WithMany(p => p.ForeignLanguages)
                .HasForeignKey(fl => fl.ProfileId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
