using OnlineJobPortal.Domain.Entities;
using OnlineJobPortal.Infrastructure.Context;
using OnlineJobPortal.Infrastructure.Implementation;

namespace OnlineJobPortal.Application.Interfaces.Repositories
{
    public class ApplyRepository : GenericRepository<Apply>, IApplyRepository
    {
        public ApplyRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
