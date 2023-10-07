using OnlineJobPortal.Application.Interfaces.Repositories;
using OnlineJobPortal.Domain.Common;

namespace OnlineJobPortal.Application.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
<<<<<<< HEAD
        IGenericRepository<T> Repository<T>() where T : class;

=======
>>>>>>> a77affc88f928922f811dfb7c1325281e8d5c5c6
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
<<<<<<< HEAD
        IJobTypeRepository JobTypeRepository { get; }
        IJobFavoriteRepository JobFavoriteRepository { get; }
        IJobPostRepository JobPostRepository { get; }
        IRequirementSkillRepository JobRequirementRepository { get; }
        IMessageRepository MessageRepository { get; }
        IProfileRepository ProfileRepository { get; }
        ISkillRepository SkillRepository { get; }
        IForeignLanguageRepository ForeignLanguageRepository { get; }
=======
        IJobCategoryRepository JobCategoryRepository { get; }
        IJobFavoriteRepository JobFavoriteRepository { get; }
        IJobPostRepository JobPostRepository { get; }
        IJobRequirementRepository JobRequirementRepository { get; }
        IMessageRepository MessageRepository { get; }
        IProfileRepository ProfileRepository { get; }
        ISkillRepository SkillRepository { get; }
>>>>>>> a77affc88f928922f811dfb7c1325281e8d5c5c6

        Task<int> Save(CancellationToken cancellationToken);
        Task<int> SaveAsync(CancellationToken cancellationToken);
        Task<int> SaveAndRemoveCache(CancellationToken cancellationToken, params string[] cacheKeys);
        Task Rollback();
    }
}
