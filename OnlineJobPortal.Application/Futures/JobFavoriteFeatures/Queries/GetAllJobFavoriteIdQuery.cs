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

namespace OnlineJobPortal.Application.Futures.JobFavoriteFeatures.Queries
{
    public record GetAllJobFavoriteIdQuery : IRequest<List<int>>
    {
    }

    public class GetAllJobFavoriteIdQueryHandler : IRequestHandler<GetAllJobFavoriteIdQuery, List<int>>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public GetAllJobFavoriteIdQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }

        public async Task<List<int>> Handle(GetAllJobFavoriteIdQuery request, CancellationToken cancellationToken)
        {
            var jobFavorites = await unitOfWork.Repository<JobFavorite>().GetAll
                .Select(j => j.JobPostId)
                .ToListAsync();
            return jobFavorites;
        }
    }
}
