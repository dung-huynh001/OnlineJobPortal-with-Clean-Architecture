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
    public class IsValidCandidateInfoQuery : IRequest<bool>
    {
        public IsValidCandidateInfoQuery(int candidateId)
        {
            CandidateId = candidateId;
        }
        public int CandidateId { get; }
    }

    public class IsValidCandidateInfoQueryHandler : IRequestHandler<IsValidCandidateInfoQuery, bool>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public IsValidCandidateInfoQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<bool> Handle(IsValidCandidateInfoQuery request, CancellationToken cancellationToken)
        {
            var resume = await unitOfWork.Repository<Resume>().GetAll
                .FirstOrDefaultAsync(r => r.CandidateId == request.CandidateId);

            if (resume!.CvUrl == null)
                return false;

            return true;
        }
    }
}
