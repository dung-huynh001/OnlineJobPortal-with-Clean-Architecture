using OnlineJobPortal.Domain.Entities;
using OnlineJobPortal.Infrastructure.Context;
using OnlineJobPortal.Infrastructure.Implementation;

namespace OnlineJobPortal.Application.Interfaces.Repositories
{
    public class JobTypeRepository : GenericRepository<JobType>, IJobTypeRepository
    {
        public JobTypeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
