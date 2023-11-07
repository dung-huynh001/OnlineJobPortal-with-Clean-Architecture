using OnlineJobPortal.Domain.Entities;
using OnlineJobPortal.Infrastructure.Context;
using OnlineJobPortal.Infrastructure.Implementation;

namespace OnlineJobPortal.Application.Interfaces.Repositories
{
    public class CandidateRepository : GenericRepository<Candidate>, ICandidateRepository
    {
        private readonly ApplicationDbContext context;

        public CandidateRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }

        public async Task<Candidate> UpdateCandidateAsync(Candidate candidate)
        {
            Candidate exist = await context.Candidates.FindAsync(candidate.Id);
            context.Entry(exist).CurrentValues.SetValues(candidate);
            ApplicationUser user = await context.Users.FindAsync(candidate.UserId);
            user.PhoneNumber = candidate.User.PhoneNumber;
            return candidate;
        }
    }
}
