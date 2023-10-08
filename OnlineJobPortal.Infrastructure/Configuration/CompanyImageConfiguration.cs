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
    public class CompanyImageConfiguration : IEntityTypeConfiguration<CompanyImage>
    {
        public void Configure(EntityTypeBuilder<CompanyImage> builder)
        {
            builder.HasKey(ci => ci.Id);

            builder.Property(ci => ci.Url)
                .IsRequired()
                .HasMaxLength(255);

            builder.HasOne(ci => ci.Company)
                .WithMany(c => c.CompanyImages)
                .HasForeignKey(ci => ci.CompanyId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
