using AutoMapper;
using MediatR;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.CandidateFeatures.Queries
{
    public class GetCandidateProfileQuery : IRequest<Candidate>
    {
        public int Id { get; set; }
        public GetCandidateProfileQuery(int id)
        {
            Id = id;
        }
    }

    public class GetCandidateProfileQueryHandler : IRequestHandler<GetCandidateProfileQuery, Candidate?>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public GetCandidateProfileQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<Candidate?> Handle(GetCandidateProfileQuery request, CancellationToken cancellationToken)
        {
            var candidate = await unitOfWork.Repository<Candidate>().GetByIdAsync(request.Id);

            if (candidate == null) return null;
            return candidate;
        }
    }
}
