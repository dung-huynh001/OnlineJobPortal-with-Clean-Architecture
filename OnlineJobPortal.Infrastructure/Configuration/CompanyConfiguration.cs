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
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.CompanyName)
                .IsRequired()
                .HasMaxLength(256);

            builder.Property(c => c.Owner)
                .IsRequired(false)
                .HasMaxLength(256);

            builder.Property(c => c.EstablishmentDate)
                .HasColumnType("Date")
                .IsRequired();

            builder.Property(c => c.LogoUrl)
                .IsRequired();

            builder.Property(c => c.Address)
                .IsRequired(false)
                .HasMaxLength(200);

            builder.Property(c => c.Hotline)
                .IsRequired(false)
                .HasMaxLength(200);

            builder.Property(c => c.Description)
                .IsRequired(false)
                .HasColumnType("ntext");

            builder.Property(c => c.Facebook)
                .IsRequired(false)
                .HasMaxLength(255);

            builder.Property(c => c.Twitter)
                .IsRequired(false)
                .HasMaxLength(255);

            builder.Property(c => c.WebsiteUrl)
                .IsRequired(false)
                .HasMaxLength(255);

            builder.HasOne(c => c.BussinessIndustry)
                .WithMany(bi => bi.Companies)
                .HasForeignKey(c => c.BussinessIndustryId)
                .IsRequired(false);

            builder.HasMany(c => c.CompanyImages)
                .WithOne(ci => ci.Company)
                .HasForeignKey(ci => ci.CompanyId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(c => c.Employers)
                .WithOne(e => e.Company)
                .HasForeignKey(e => e.CompanyId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
