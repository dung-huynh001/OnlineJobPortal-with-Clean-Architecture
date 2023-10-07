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
    public class RequirementSkillConfiguration : IEntityTypeConfiguration<RequirementSkill>
    {
        public void Configure(EntityTypeBuilder<RequirementSkill> builder)
        {
            throw new NotImplementedException();
        }
    }
}
