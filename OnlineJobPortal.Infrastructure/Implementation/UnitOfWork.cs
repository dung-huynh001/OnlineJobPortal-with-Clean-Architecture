using Microsoft.EntityFrameworkCore;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Application.Interfaces.Repositories;
using OnlineJobPortal.Domain.Common;
using OnlineJobPortal.Infrastructure.Context;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Infrastructure.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private Hashtable _repositories;
        private bool disposed;


        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }
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

        public IDistrictRepository DistrictRepository => throw new NotImplementedException();

        public IProvinceRepository ProvinceRepository => throw new NotImplementedException();

        public void Dispose()
        {
            _context.Dispose();
        }

        public IGenericRepository<T> Repository<T>() where T : BaseEntity
        {
            if (_repositories == null)
                _repositories = new Hashtable();

            var type = typeof(T).Name;

            if (!_repositories.ContainsKey(type))
            {
                var repositoryType = typeof(GenericRepository<>);

                var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(T)), _context);

                _repositories.Add(type, repositoryInstance);
            }

            return (IGenericRepository<T>)_repositories[type];
        }

        public Task Rollback()
        {
            _context.ChangeTracker.Entries().ToList().ForEach(x => x.Reload());
            return Task.CompletedTask;
        }

        public async Task<int> SaveAsync(CancellationToken cancellationToken)
        {
            return await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
