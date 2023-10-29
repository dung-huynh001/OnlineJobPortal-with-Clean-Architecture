using OnlineJobPortal.Domain.Entities;
using OnlineJobPortal.Infrastructure.Context;
using OnlineJobPortal.Infrastructure.Implementation;

namespace OnlineJobPortal.Application.Interfaces.Repositories
{
    public class SkillRepository : GenericRepository<Skill>, ISkillRepository
    {
        private readonly ApplicationDbContext context;

        public SkillRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }
    }
}
