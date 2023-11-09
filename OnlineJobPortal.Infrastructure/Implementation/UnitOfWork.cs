using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Application.Interfaces.Repositories;
using OnlineJobPortal.Domain.Common;
using OnlineJobPortal.Infrastructure.Context;
using OnlineJobPortal.Infrastructure.Implementation.Repositories;
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
        private IDbContextTransaction _transaction;

        private IAdminRepository _adminRepository;
        private IApplyRepository _applyRepository;
        private IBussinessIndustryRepository _bussinessIndustryRepository;
        private ICandidateRepository _candidateRepository;
        private ICandidateSkillRepository _candidateSkillRepository;
        private ICompanyImageRepository _companyImageRepository;
        private ICompanyRepository _companyRepository;
        private IEducationRepository _educationRepository;
        private IEmployerRepository _employerRepository;
        private IExperienceRepository _experienceRepository;
        private IJobTypeRepository _jobTypeRepository;
        private IJobFavoriteRepository _jobFavoriteRepository;
        private IJobPostRepository _jobPostRepository;
        private IRequirementSkillRepository _requirementSkillRepository;
        private IMessageRepository _messageRepository;
        private IResumeRepository _resumeRepository;
        private ISkillRepository _skillRepository;
        private IForeignLanguageRepository _foreignLanguageRepository;
        private IDistrictRepository _districtRepository;
        private IProvinceRepository _provinceRepository;
        private IProjectRepository _projectRepository;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        //Implement repositories
        public IAdminRepository AdminRepository => _adminRepository ??= new AdminRepository(_context);
        public IApplyRepository ApplicationRepository => _applyRepository ??= new ApplyRepository(_context);
        public IBussinessIndustryRepository BussinessIndustryRepository => _bussinessIndustryRepository ??= new BussinessIndustryRepository(_context);
        public ICandidateRepository CandidateRepository => _candidateRepository ??= new CandidateRepository(_context);
        public ICandidateSkillRepository CandidateSkillRepository => _candidateSkillRepository ??= new CandidateSkillRepository(_context);
        public ICompanyImageRepository CompanyImageRepository => _companyImageRepository ??= new CompanyImageRepository(_context);
        public ICompanyRepository CompanyRepository => _companyRepository ??= new CompanyRepository(_context);
        public IEducationRepository EducationRepository => _educationRepository ??= new EducationRepository(_context);
        public IEmployerRepository EmployerRepository => _employerRepository ??= new EmployerRepository(_context);
        public IExperienceRepository ExperienceRepository => _experienceRepository ??= new ExperienceRepository(_context);
        public IJobTypeRepository JobTypeRepository => _jobTypeRepository ??= new JobTypeRepository(_context);
        public IJobFavoriteRepository JobFavoriteRepository => _jobFavoriteRepository ??= new JobFavoriteRepository(_context);
        public IJobPostRepository JobPostRepository => _jobPostRepository ??= new JobPostRepository(_context);
        public IRequirementSkillRepository RequirementSkillRepository => _requirementSkillRepository ??= new RequirementSkillRepository(_context);
        public IMessageRepository MessageRepository => _messageRepository ??= new MessageRepository(_context);
        public IResumeRepository ResumeRepository => _resumeRepository ??= new ResumeRepository(_context);
        public ISkillRepository SkillRepository => _skillRepository ??= new SkillRepository(_context);
        public IForeignLanguageRepository ForeignLanguageRepository => _foreignLanguageRepository ??= new ForeignLanguageRepository(_context);
        public IDistrictRepository DistrictRepository => _districtRepository ??= new DistrictRepository(_context);
        public IProvinceRepository ProvinceRepository => _provinceRepository ??= new ProvinceRepository(_context);
        public IProjectRepository ProjectRepository => _projectRepository ??= new ProjectRepository(_context);
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

        public void BeginTransaction()
        {
            _transaction = _context.Database.BeginTransaction();
        }

        public void Commit()
        {
            try
            {
                _context.SaveChangesAsync().GetAwaiter().GetResult();
                _transaction.Commit();
            }
            catch
            {
                _transaction.Rollback();
                throw;
            }
            finally
            {
                _transaction.Dispose();
            }
        }

        public void Rollback()
        {
            _transaction.Rollback();
            _transaction.Dispose();
        }

        public async Task<int> SaveAsync(CancellationToken cancellationToken)
        {
            return await _context.SaveChangesAsync(cancellationToken);
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
