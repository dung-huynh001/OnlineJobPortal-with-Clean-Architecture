using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using OnlineJobPortal.Application.DTOs.ResumeDto;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.ResumeFeatures.Queries
{
    public class GetResumeToSuggestJobsQuery : IRequest<GetResumeToSuggestJobsDto?>
    {
        public GetResumeToSuggestJobsQuery(int candidateId)
        {
            CandidateId = candidateId;
        }

        public int CandidateId { get; }
    }
    public class GetResumeToSuggestJobsQueryHandler : IRequestHandler<GetResumeToSuggestJobsQuery, GetResumeToSuggestJobsDto?>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public GetResumeToSuggestJobsQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<GetResumeToSuggestJobsDto?> Handle(GetResumeToSuggestJobsQuery request, CancellationToken cancellationToken)
        {
            unitOfWork.BeginTransaction();
            try
            {
                var result = new GetResumeToSuggestJobsDto();
                var resume = await unitOfWork.Repository<Resume>().GetAll
                    .FirstOrDefaultAsync(r => r.CandidateId.Equals(request.CandidateId));
                if (resume == null) 
                {
                    throw new Exception();
                }
                result.experience = resume.Position;
                if(resume.Educations != null && resume.Educations.Count > 0)
                {
                    result.education = resume.Educations.FirstOrDefault(e => e.ResumeId.Equals(resume.Id)).University;
                }
                else
                {
                    result.education = "";
                }
                var candidateSkills = unitOfWork.Repository<CandidateSkill>().GetAll
                    .Include(cs => cs.Skill)
                    .Where(cs => cs.ResumeId.Equals(resume.Id))
                    .Select(cs => cs.Skill.SkillName);
                result.skills = await candidateSkills.ToListAsync();
                unitOfWork.Commit();
                return result;
            }
            catch
            {
                unitOfWork.Rollback();
                return null;
            }
        }
    }
}
