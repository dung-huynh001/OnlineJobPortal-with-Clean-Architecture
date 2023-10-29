using Microsoft.EntityFrameworkCore;
using OnlineJobPortal.Application.Interfaces.Repositories;
using OnlineJobPortal.Domain.Common;

namespace OnlineJobPortal.Application.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<T> Repository<T>() where T : BaseEntity;
        IAdminRepository AdminRepository { get; }
        IApplyRepository ApplicationRepository { get; }
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
        IRequirementSkillRepository RequirementSkillRepository { get; }
        IMessageRepository MessageRepository { get; }
        IResumeRepository ResumeRepository { get; }
        ISkillRepository SkillRepository { get; }
        IForeignLanguageRepository ForeignLanguageRepository { get; }
        IDistrictRepository DistrictRepository { get; }
        IProvinceRepository ProvinceRepository { get; }
        void BeginTransaction();
        void Commit();
        void Rollback();
        Task<int> SaveAsync(CancellationToken cancellationToken);
    }
}
