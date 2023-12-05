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

namespace OnlineJobPortal.Application.Futures.EmployerFeatures.Queries
{
    public record GetAllAppliedEmployersQuery : IRequest<List<Apply>?>
    {
        public GetAllAppliedEmployersQuery(int candidateId)
        {
            CandidateId = candidateId;
        }

        public int CandidateId { get; }
    }

    public class GetAllAppliedEmployersQueryHandler : IRequestHandler<GetAllAppliedEmployersQuery, List<Apply>?>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public GetAllAppliedEmployersQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<List<Apply>?> Handle(GetAllAppliedEmployersQuery request, CancellationToken cancellationToken)
        {
            var appliedJobs = await unitOfWork.Repository<Apply>().GetAll
                .Include(a => a.JobPost.Employer.User)
                .Include(a => a.JobPost.Employer.Company)
                .Where(a => a.CandidateId == request.CandidateId)
                .ToListAsync();
            foreach(var appliedJob in appliedJobs)
            {
                var conversation = await unitOfWork.Repository<Conversations>().GetAll
                .Where(c => c.ApplyId == appliedJob.Id)
                .FirstOrDefaultAsync();

                appliedJob.ConversationId = conversation!.Id;
            }
            
            return appliedJobs;
        }
    }
}
