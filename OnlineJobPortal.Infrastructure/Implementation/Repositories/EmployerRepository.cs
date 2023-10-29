using Microsoft.EntityFrameworkCore;
using OnlineJobPortal.Domain.Entities;
using OnlineJobPortal.Infrastructure.Context;
using OnlineJobPortal.Infrastructure.Implementation;

namespace OnlineJobPortal.Application.Interfaces.Repositories
{
    public class EmployerRepository : GenericRepository<Employer>, IEmployerRepository
    {
        private readonly ApplicationDbContext context;

        public EmployerRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }
    }
}
