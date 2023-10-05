using OnlineJobPortal.Application.Interfaces.Repositories;
using OnlineJobPortal.Domain.Common;

namespace OnlineJobPortal.Application.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<T> Repository<T>() where T : class;

        IAdminRepository AdminRepository { get; }
        IApplicationRepository ApplicationRepository { get; }
        IBussinessIndustryRepository BussinessIndustryRepository { get; }
        ICandidateRepository CandidateRepository { get; }
        ICandidateSkillRepository CandidateSkillRepository { get; }
        ICompanyImageRepository CompanyImageRepository { get; }
        ICompanyRepository CompanyRepository { get; }
        IEducationRepository EducationRepository { get; }
        IEmployerRepository EmployerRepository { get; }
        IExperienceRepository ExperienceRepository { get; }
        IJobTypeRepository JobTypeRepository { get; }
        IJobFavoriteRepository JobFavoriteRepository { get; }
        IJobPostRepository JobPostRepository { get; }
        IRequirementSkillRepository JobRequirementRepository { get; }
        IMessageRepository MessageRepository { get; }
        IProfileRepository ProfileRepository { get; }
        ISkillRepository SkillRepository { get; }
        IForeignLanguageRepository ForeignLanguageRepository { get; }

        Task<int> Save(CancellationToken cancellationToken);
        Task<int> SaveAsync(CancellationToken cancellationToken);
        Task<int> SaveAndRemoveCache(CancellationToken cancellationToken, params string[] cacheKeys);
        Task Rollback();
    }
}
