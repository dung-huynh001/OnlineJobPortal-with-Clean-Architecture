using OnlineJobPortal.Domain.Entities;
using OnlineJobPortal.Infrastructure.Context;
using OnlineJobPortal.Infrastructure.Implementation;

namespace OnlineJobPortal.Application.Interfaces.Repositories
{
    public class RequirementSkillRepository : GenericRepository<RequirementSkill>, IRequirementSkillRepository
    {
        public RequirementSkillRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
