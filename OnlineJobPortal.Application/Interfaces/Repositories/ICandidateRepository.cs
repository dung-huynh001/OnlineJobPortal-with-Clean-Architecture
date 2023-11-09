using OnlineJobPortal.Domain.Entities;

namespace OnlineJobPortal.Application.Interfaces.Repositories
{
    public interface ICandidateRepository : IGenericRepository<Candidate>
    {
        Task<Candidate> CreateCandidateAsync(Candidate candidate);
        Task<Candidate> UpdateCandidateAsync(Candidate candidate);
    }
}
