using Microsoft.EntityFrameworkCore;
using OnlineJobPortal.Domain.Entities;
using OnlineJobPortal.Infrastructure.Context;
using OnlineJobPortal.Infrastructure.Implementation;

namespace OnlineJobPortal.Application.Interfaces.Repositories
{
    public class JobPostRepository : GenericRepository<JobPost>, IJobPostRepository
    {
        private readonly ApplicationDbContext context;

        public JobPostRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }

        public async Task<JobPost> GetJobPostWithAllProperties(int id)
        {
            var result = await context.JobPosts
                .Include(j => j.District)
                .ThenInclude(d => d.Province)
                .Include(j => j.JobType)
                .Include(j => j.Employer)
                .ThenInclude(e => e.Company)
                .Include(j => j.RequirementSkills)
                .ThenInclude(r => r.Skill)
                .Where(c => c.Id.Equals(id))
                .FirstOrDefaultAsync();
            return result;
        }
    }
}
