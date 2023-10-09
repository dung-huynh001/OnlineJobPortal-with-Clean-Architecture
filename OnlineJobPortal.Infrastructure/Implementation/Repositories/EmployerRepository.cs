using OnlineJobPortal.Domain.Entities;
using OnlineJobPortal.Infrastructure.Context;
using OnlineJobPortal.Infrastructure.Implementation;

namespace OnlineJobPortal.Application.Interfaces.Repositories
{
    public class EmployerRepository : GenericRepository<Employer>, IEmployerRepository
    {
        public EmployerRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
