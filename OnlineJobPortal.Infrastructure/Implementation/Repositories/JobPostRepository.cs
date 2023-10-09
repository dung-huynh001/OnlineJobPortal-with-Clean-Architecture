using OnlineJobPortal.Domain.Entities;
using OnlineJobPortal.Infrastructure.Context;
using OnlineJobPortal.Infrastructure.Implementation;

namespace OnlineJobPortal.Application.Interfaces.Repositories
{
    public class JobPostRepository : GenericRepository<JobPost>, IJobPostRepository
    {
        public JobPostRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
