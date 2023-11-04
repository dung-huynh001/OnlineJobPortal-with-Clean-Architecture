using OnlineJobPortal.Domain.Entities;

namespace OnlineJobPortal.Application.Interfaces.Repositories
{
    public interface ICompanyRepository : IGenericRepository<Company>
    {
        Task<Company> GetCompanyByEmployerId (int employerId);
        Task<Company> GetCompanyDetailById(int companyId);
    }
}
