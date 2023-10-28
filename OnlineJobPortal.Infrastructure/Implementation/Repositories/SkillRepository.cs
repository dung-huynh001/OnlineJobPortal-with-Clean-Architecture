using OnlineJobPortal.Domain.Entities;
using OnlineJobPortal.Infrastructure.Context;
using OnlineJobPortal.Infrastructure.Implementation;

namespace OnlineJobPortal.Application.Interfaces.Repositories
{
    public class SkillRepository : ISkillRepository
    {
        private readonly IGenericRepository<Skill> repository;

        public SkillRepository(IGenericRepository<Skill> repository)
        {
            this.repository = repository;
        }
    }
}
