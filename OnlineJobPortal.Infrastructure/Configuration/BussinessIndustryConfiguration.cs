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
    public class BussinessIndustryConfiguration : IEntityTypeConfiguration<BussinessIndustry>
    {
        public void Configure(EntityTypeBuilder<BussinessIndustry> builder)
        {
            builder.HasKey(bi => bi.Id);

            builder.Property(bi => bi.BussinessName)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
