using Microsoft.EntityFrameworkCore;
using OnlineJobPortal.Application.DTOs.JobTypeDto;
using OnlineJobPortal.Domain.Entities;
using OnlineJobPortal.Infrastructure.Context;
using OnlineJobPortal.Infrastructure.Implementation;

namespace OnlineJobPortal.Application.Interfaces.Repositories
{
    public class JobTypeRepository : GenericRepository<JobType>, IJobTypeRepository
    {
        private readonly ApplicationDbContext context;

        public JobTypeRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }

        public async Task<List<GetJobTypeWithPaginationDto>> GetAllJobTypeWithTotalJobPost()
        {
            var result = await context.JobTypes
                .Select(jt => new GetJobTypeWithPaginationDto
                {
                    Id = jt.Id,
                    JobTypeName = jt.JobTypeName,
                    JobTypeIcon = jt.JobTypeIcon,
                    TotalJobPost = jt.JobPost != null ? jt.JobPost.Count : 0
                })
                .ToListAsync();

            return result;
        }

    }
}
