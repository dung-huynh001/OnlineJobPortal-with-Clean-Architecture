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
            var candidate = await unitOfWork.Repository<Candidate>().GetAll
            .Include(c => c.User)
            .Include(c => c.Resume).ThenInclude(r => r.Experiences).ThenInclude(e => e.Projects)
            .Include(c => c.Resume).ThenInclude(r => r.Experiences).ThenInclude(e => e.Skills)
            .Include(c => c.Resume).ThenInclude(r => r.Project)
            .FirstOrDefaultAsync(c => c.Id.Equals(request.Id));
            return candidate;
        }
    }
}
