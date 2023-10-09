using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Application.Interfaces.Repositories;
using OnlineJobPortal.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Infrastructure.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        public IAdminRepository AdminRepository => throw new NotImplementedException();

        public IApplyRepository ApplicationRepository => throw new NotImplementedException();

        public IBussinessIndustryRepository BussinessIndustryRepository => throw new NotImplementedException();

        public ICandidateRepository CandidateRepository => throw new NotImplementedException();

        public ICandidateSkillRepository CandidateSkillRepository => throw new NotImplementedException();

        public ICompanyImageRepository CompanyImageRepository => throw new NotImplementedException();

        public ICompanyRepository CompanyRepository => throw new NotImplementedException();

        public IEducationRepository EducationRepository => throw new NotImplementedException();

        public IEmployerRepository EmployerRepository => throw new NotImplementedException();

        public IExperienceRepository ExperienceRepository => throw new NotImplementedException();

        public IJobTypeRepository JobTypeRepository => throw new NotImplementedException();

        public IJobFavoriteRepository JobFavoriteRepository => throw new NotImplementedException();

        public IJobPostRepository JobPostRepository => throw new NotImplementedException();

        public IRequirementSkillRepository RequirementSkillRepository => throw new NotImplementedException();

        public IMessageRepository MessageRepository => throw new NotImplementedException();

        public IResumeRepository ResumeRepository => throw new NotImplementedException();

        public ISkillRepository SkillRepository => throw new NotImplementedException();

        public IForeignLanguageRepository ForeignLanguageRepository => throw new NotImplementedException();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IGenericRepository<T> Repository<T>() where T : class
        {
            throw new NotImplementedException();
        }

        public Task Rollback()
        {
            throw new NotImplementedException();
        }

        public Task<int> Save(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveAndRemoveCache(CancellationToken cancellationToken, params string[] cacheKeys)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
