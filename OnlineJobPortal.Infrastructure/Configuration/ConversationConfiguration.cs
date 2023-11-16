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
    public class ConversationConfiguration : IEntityTypeConfiguration<Conversations>
    {
        public void Configure(EntityTypeBuilder<Conversations> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
