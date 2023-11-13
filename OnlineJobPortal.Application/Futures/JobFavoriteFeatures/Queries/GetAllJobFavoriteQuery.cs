using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Application.Responses;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.JobFavoriteFeatures.Queries
{
    public record GetAllJobFavoriteQuery : IRequest<PaginatedResult<JobFavorite>>
    {
        public GetAllJobFavoriteQuery(int candidateId)
        {
            CandidateId = candidateId;
        }

        public int CandidateId { get; }
    }

    public class GetAllJobFavoriteQueryHandler : IRequestHandler<GetAllJobFavoriteQuery, PaginatedResult<JobFavorite>>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public GetAllJobFavoriteQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<PaginatedResult<JobFavorite>> Handle(GetAllJobFavoriteQuery request, CancellationToken cancellationToken)
        {
            return await unitOfWork.Repository<JobFavorite>().GetAll
                .Include(j => j.JobPost)
                .ThenInclude(jp => jp.Employer)
                .ThenInclude(e => e.Company)
                .ThenInclude(c => c.District)
                .ThenInclude(d => d.Province)
                .Include(j => j.JobPost)
                .ThenInclude(jp => jp.RequirementSkills)
                .ThenInclude(rs => rs.Skill)
                .Where(j => j.CandidateId.Equals(request.CandidateId))
                .ToPaginatedListAsync(0, 10, cancellationToken);
        }
    }
}
