using OnlineJobPortal.Domain.Entities;

namespace OnlineJobPortal.Application.Interfaces.Repositories
{
    public interface IJobPostRepository : IGenericRepository<JobPost>
    {
        Task<JobPost> GetJobPostWithAllProperties(int id);
    }
}
