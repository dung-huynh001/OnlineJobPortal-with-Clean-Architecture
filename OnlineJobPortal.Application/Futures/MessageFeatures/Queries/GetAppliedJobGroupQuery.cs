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

namespace OnlineJobPortal.Application.Futures.MessageFeatures.Queries
{
    public class GetAppliedJobGroupQuery : IRequest<List<int>>
    {
        public GetAppliedJobGroupQuery(int candidateId)
        {
            CandidateId = candidateId;
        }
        public int CandidateId { get; }
    }

    public class GetAppliedJobGroupQueryHandler : IRequestHandler<GetAppliedJobGroupQuery, List<int>>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public GetAppliedJobGroupQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<List<int>> Handle(GetAppliedJobGroupQuery request, CancellationToken cancellationToken)
        {
            var appliedJobs = await unitOfWork.Repository<Apply>().GetAll
                .Where(a => a.CandidateId == request.CandidateId)
                .Select(a => a.JobPostId)
                .ToListAsync();
            return appliedJobs;
        }
    }
}
