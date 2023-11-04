using Microsoft.EntityFrameworkCore;
using OnlineJobPortal.Domain.Entities;
using OnlineJobPortal.Infrastructure.Context;
using OnlineJobPortal.Infrastructure.Implementation;

namespace OnlineJobPortal.Application.Interfaces.Repositories
{
    public class CompanyRepository : GenericRepository<Company>, ICompanyRepository
    {
        private readonly ApplicationDbContext context;

        public CompanyRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }

        public async Task<Company> GetCompanyByEmployerId(int employerId)
        {
            var company = await context.Companies
                .Include(c => c.Employers)
                .Include(c => c.BussinessIndustry)
                .FirstOrDefaultAsync(c => c.Employers!.Any(e => e.Id.Equals(employerId)));

            return company;
        }

        public async Task<Company> GetCompanyDetailById(int companyId)
        {
            var result = await context.Companies
                .Include(c => c.District)
                .ThenInclude(d => d.Province)
                .Include(c => c.Employers!)
                .ThenInclude(e => e.JobPosts)
                .FirstOrDefaultAsync(c => c.Id.Equals(companyId));
            return result;
        }
    }
}
