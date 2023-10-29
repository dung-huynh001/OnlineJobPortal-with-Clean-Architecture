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
    public class AdminConfiguration : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.FullName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(a => a.NationalId)
                .IsRequired(false)
                .HasMaxLength(20);

            // Cấu hình thuộc tính Gender
            builder.Property(a => a.Gender)
                .IsRequired();

            builder.Property(a => a.DateOfBirth)
                .HasColumnType("Date")
                .IsRequired();

            builder.Property(a => a.Address)
                .HasMaxLength(200)
                .IsRequired(false);

            builder.HasOne(a => a.User)
                .WithOne()
                .HasForeignKey<Admin>(a => a.UserId);

        }
    }
}
