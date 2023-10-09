using OnlineJobPortal.Domain.Entities;
using OnlineJobPortal.Infrastructure.Context;
using OnlineJobPortal.Infrastructure.Implementation;

namespace OnlineJobPortal.Application.Interfaces.Repositories
{
    public class ForeignLanguageRepository : GenericRepository<ForeignLanguage>, IForeignLanguageRepository
    {
        public ForeignLanguageRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
