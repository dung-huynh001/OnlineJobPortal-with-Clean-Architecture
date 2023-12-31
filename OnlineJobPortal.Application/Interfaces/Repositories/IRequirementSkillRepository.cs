﻿using OnlineJobPortal.Domain.Entities;

namespace OnlineJobPortal.Application.Interfaces.Repositories
{
    public interface IRequirementSkillRepository : IGenericRepository<RequirementSkill>
    {
        Task<ICollection<string>> GetRequirementSkillsByJobPostId(int jobId);
    }
}
