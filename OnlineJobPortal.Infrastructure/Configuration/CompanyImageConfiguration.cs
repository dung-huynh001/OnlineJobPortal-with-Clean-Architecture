﻿using Microsoft.EntityFrameworkCore;
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
            throw new NotImplementedException();
        }
    }
}