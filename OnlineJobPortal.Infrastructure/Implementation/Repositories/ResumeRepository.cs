using AutoMapper;
using OnlineJobPortal.Domain.Entities;
using OnlineJobPortal.Infrastructure.Context;
using OnlineJobPortal.Infrastructure.Implementation;

namespace OnlineJobPortal.Application.Interfaces.Repositories
{
    public class ResumeRepository : GenericRepository<Resume>, IResumeRepository
    {
        public ResumeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
