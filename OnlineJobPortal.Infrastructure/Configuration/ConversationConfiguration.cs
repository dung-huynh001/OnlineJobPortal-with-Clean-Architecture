using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Infrastructure.Configuration
{
    public class ConversationConfiguration : IEntityTypeConfiguration<Conversations>
    {
        public void Configure(EntityTypeBuilder<Conversations> builder)
        {
            builder.HasKey(e => e.Id);
            builder.HasOne(e => e.Apply)
                .WithOne(e => e.Conversations)
                .HasForeignKey<Conversations>(e => e.ApplyId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
