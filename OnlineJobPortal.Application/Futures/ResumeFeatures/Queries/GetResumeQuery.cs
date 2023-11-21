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
    public class GetResumeQuery : IRequest<Resume>
    {
        public int CandidateId { get; set; }
        public GetResumeQuery(int candidateId)
        {
            CandidateId = candidateId;
        }
    }
    public class GetResumeQueryHandler : IRequestHandler<GetResumeQuery, Resume?>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public GetResumeQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<Resume?> Handle(GetResumeQuery request, CancellationToken cancellationToken)
        {
            var result = await unitOfWork.Repository<Resume>().GetAll
                .Include(r => r.Project)
                .Include(r => r.CandidateSkills)
                .ThenInclude(cs => cs.Skill)
                .Include(r => r.Educations)
                .Include(r => r.Experiences!).ThenInclude(e => e.ExperienceProjects)
                .Include(r => r.Experiences!).ThenInclude(e => e.ExperienceSkills!).ThenInclude(e => e.Skill)
                .Include(r => r.ForeignLanguages)
                .FirstOrDefaultAsync(r => r.CandidateId.Equals(request.CandidateId));
            return result;
        }
    }
}
