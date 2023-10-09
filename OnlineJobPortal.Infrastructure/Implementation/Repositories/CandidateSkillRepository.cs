using OnlineJobPortal.Domain.Entities;
using OnlineJobPortal.Infrastructure.Context;
using OnlineJobPortal.Infrastructure.Implementation;

namespace OnlineJobPortal.Application.Interfaces.Repositories
{
    public class CandidateSkillRepository : GenericRepository<CandidateSkill>, ICandidateSkillRepository
    {
        public CandidateSkillRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
