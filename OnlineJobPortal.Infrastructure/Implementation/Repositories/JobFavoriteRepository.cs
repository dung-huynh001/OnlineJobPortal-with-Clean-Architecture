using OnlineJobPortal.Domain.Entities;
using OnlineJobPortal.Infrastructure.Context;
using OnlineJobPortal.Infrastructure.Implementation;

namespace OnlineJobPortal.Application.Interfaces.Repositories
{
    public class JobFavoriteRepository : GenericRepository<JobFavorite>, IJobFavoriteRepository
    {
        public JobFavoriteRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
