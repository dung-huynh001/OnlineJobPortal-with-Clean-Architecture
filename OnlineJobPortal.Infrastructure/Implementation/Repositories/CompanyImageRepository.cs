using OnlineJobPortal.Domain.Entities;
using OnlineJobPortal.Infrastructure.Context;
using OnlineJobPortal.Infrastructure.Implementation;

namespace OnlineJobPortal.Application.Interfaces.Repositories
{
    public class CompanyImageRepository : GenericRepository<CompanyImage>, ICompanyImageRepository
    {
        public CompanyImageRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
