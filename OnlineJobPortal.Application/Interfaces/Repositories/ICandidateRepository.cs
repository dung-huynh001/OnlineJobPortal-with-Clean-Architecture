using OnlineJobPortal.Domain.Entities;

namespace OnlineJobPortal.Application.Interfaces.Repositories
{
    public interface ICandidateRepository : IGenericRepository<Candidate>
    {
        Task<Candidate> UpdateCandidateAsync(Candidate candidate);
    }
}
