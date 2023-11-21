using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.ResumeFeatures.Queries
{
    public record GetAllCandidateSearchingJobsQuery : IRequest<List<Resume>?>
    {
    }

    public class GetAllCandidateSearchingJobsQueryHandler : IRequestHandler<GetAllCandidateSearchingJobsQuery, List<Resume>?>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public GetAllCandidateSearchingJobsQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<List<Resume>?> Handle(GetAllCandidateSearchingJobsQuery request, CancellationToken cancellationToken)
        {
            var result = await unitOfWork.Repository<Resume>()
                .GetAll
                .Include(r => r.Candidate.User)
                .Include(r => r.CandidateSkills).ThenInclude(cs => cs.Skill)
                .Include(r => r.ForeignLanguages)
                .Include(r => r.Educations)
                .Include(r => r.Experiences).ThenInclude(e => e.ExperienceSkills).ThenInclude(es => es.Skill)
                .Include(r => r.Project)
                .Where(r => r.JobSearchMode)
                .ToListAsync(cancellationToken);

            return result;
        }

    }
}
