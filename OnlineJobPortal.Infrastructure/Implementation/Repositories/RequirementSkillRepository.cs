using Microsoft.EntityFrameworkCore;
using OnlineJobPortal.Domain.Entities;
using OnlineJobPortal.Infrastructure.Context;
using OnlineJobPortal.Infrastructure.Implementation;
using System.Collections.Generic;

namespace OnlineJobPortal.Application.Interfaces.Repositories
{
    public class RequirementSkillRepository : GenericRepository<RequirementSkill>, IRequirementSkillRepository
    {
        private readonly ApplicationDbContext context;

        public RequirementSkillRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }

        public async Task<ICollection<string>> GetRequirementSkillsByJobPostId(int jobId)
        {
            var skillNames = await context.RequirementSkills
                .Include(r => r.Skill)
                .Where(r => r.JobPostId.Equals(jobId))
                .Select(r => r.Skill.SkillName)
                .ToListAsync();

            return skillNames;
        }

    }
}
