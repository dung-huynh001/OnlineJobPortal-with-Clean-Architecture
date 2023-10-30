using OnlineJobPortal.Application.DTOs.JobTypeDto;
using OnlineJobPortal.Domain.Entities;

namespace OnlineJobPortal.Application.Interfaces.Repositories
{
    public interface IJobTypeRepository : IGenericRepository<JobType>
    {
        Task<List<GetJobTypeWithPaginationDto>> GetAllJobTypeWithTotalJobPost();
    }
}
