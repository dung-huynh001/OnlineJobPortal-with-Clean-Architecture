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
    public class ApplicationConfiguration : IEntityTypeConfiguration<OnlineJobPortal.Domain.Entities.Application>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Application> builder)
        {
            throw new NotImplementedException();
        }
    }
}
