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

namespace OnlineJobPortal.Application.Futures.ApplyFeatures.Queries
{
    public record GetAllAppliedJobsQuery : IRequest<List<Apply>>
    {
        public GetAllAppliedJobsQuery(int candidateId)
        {
            CandidateId = candidateId;
        }

        public int CandidateId { get; }
    }

    public class GetAllAppliedJobsQueryHandler : IRequestHandler<GetAllAppliedJobsQuery, List<Apply>>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public GetAllAppliedJobsQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<List<Apply>> Handle(GetAllAppliedJobsQuery request, CancellationToken cancellationToken)
        {
            var result = await unitOfWork.Repository<Apply>().GetAll
                .Include(a => a.JobPost.RequirementSkills)
                .ThenInclude(rs => rs.Skill)
                .Include(a => a.JobPost.Employer.Company)
                .Include(a => a.JobPost.District.Province)
                .Where(a => a.CandidateId == request.CandidateId)
                .ToListAsync();
            return result;
        }
    }
}
