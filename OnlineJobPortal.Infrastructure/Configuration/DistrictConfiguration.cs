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
    public class DistrictConfiguration : IEntityTypeConfiguration<District>
    {
        public void Configure(EntityTypeBuilder<District> builder)
        {
            builder.HasOne(d => d.Province)
                .WithMany(p => p.Districts)
                .HasForeignKey(d => d.ProvinceId);
            builder.Property(d => d.DistrictName)
                .IsRequired();
            builder.Property(d => d.ProvinceId)
                .IsRequired();
            builder.Property(d => d.Id)
                .IsRequired();
            builder.HasKey(d => new {d.Id, d.ProvinceId});

            builder.HasMany(d => d.Companies)
                .WithOne(c => c.District)
                .HasForeignKey(c => new { c.DistrictId, c.ProvinceId});
        }
    }
}
