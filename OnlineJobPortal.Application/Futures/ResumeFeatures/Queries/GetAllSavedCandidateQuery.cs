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
    public record GetAllSavedCandidateQuery : IRequest<List<Resume>?>
    {
    }

    public class GetAllSavedCandidateQueryHandler : IRequestHandler<GetAllSavedCandidateQuery, List<Resume>?>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public GetAllSavedCandidateQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<List<Resume>?> Handle(GetAllSavedCandidateQuery request, CancellationToken cancellationToken)
        {
            /*var result = await unitOfWork.Repository<SaveCandidate>().GetAll
                .Include(s => s.Candidate.User)
                .Include(s => s.Candidate.Resume.Experiences).ThenInclude(e => e.ExperienceProjects)
                .Include(s => s.Candidate.Resume.Experiences).ThenInclude(e => e.ExperienceSkills)
                .Include(s => s.Candidate.Resume.CandidateSkills).ThenInclude(cs => cs.Skill)
                .Include(s => s.Candidate.Resume.ForeignLanguages)
                .Include(s => s.Candidate.Resume.Educations)
                .Include(s => s.Candidate.Resume.Project)
                .ToListAsync();*/

            var savedCandidates = unitOfWork.Repository<SaveCandidate>().GetAll
                .Select(s => s.CandidateId);

            var result = await unitOfWork.Repository<Resume>()
                .GetAll
                .Include(r => r.Candidate.User)
                .Include(r => r.Candidate.SaveCandidates)
                .Include(r => r.CandidateSkills).ThenInclude(cs => cs.Skill)
                .Include(r => r.ForeignLanguages)
                .Include(r => r.Educations)
                .Include(r => r.Experiences).ThenInclude(e => e.ExperienceSkills).ThenInclude(es => es.Skill)
                .Include(r => r.Project)
                .Where(r => savedCandidates.Contains(r.CandidateId))
                .ToListAsync(cancellationToken);

            return result;
        }
    }
}
