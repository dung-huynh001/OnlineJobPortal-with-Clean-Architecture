using OnlineJobPortal.Domain.Entities;
using OnlineJobPortal.Infrastructure.Context;
using OnlineJobPortal.Infrastructure.Implementation;

namespace OnlineJobPortal.Application.Interfaces.Repositories
{
    public class BussinessIndustryRepository : GenericRepository<BussinessIndustry>, IBussinessIndustryRepository
    {
        public BussinessIndustryRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
