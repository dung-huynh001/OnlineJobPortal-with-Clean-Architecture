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

namespace OnlineJobPortal.Application.Futures.CandidateFeatures.Queries
{
    public record GetAllAppliedCandidatesQuery : IRequest<List<Apply>?>
    {
        public GetAllAppliedCandidatesQuery(int employerId)
        {
            EmployerId = employerId;
        }

        public int EmployerId { get; }
    }

    public class GetAllAppliedCandidatesQueryHandler : IRequestHandler<GetAllAppliedCandidatesQuery, List<Apply>?>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public GetAllAppliedCandidatesQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<List<Apply>?> Handle(GetAllAppliedCandidatesQuery request, CancellationToken cancellationToken)
        {
            var appliedJobs = await unitOfWork.Repository<Apply>().GetAll
                .Include(a => a.Candidate)
                .Include(a => a.JobPost)
                .Where(a => a.JobPost.EmployerId == request.EmployerId)
                .ToListAsync();
            return appliedJobs;
        }
    }
}
