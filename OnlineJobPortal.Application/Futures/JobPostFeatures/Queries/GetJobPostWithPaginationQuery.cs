using AutoMapper;
using MediatR;
using OnlineJobPortal.Application.DTOs.JobPostDto;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Application.Responses;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.JobPostFeatures.Queries
{
    public record GetJobPostWithPaginationQuery : IRequest<PaginatedResult<GetJobPostWithPaginationDto>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public GetJobPostWithPaginationQuery() { }
        public GetJobPostWithPaginationQuery(int pageNumber, int pageSize)
        {
            this.PageNumber = pageNumber;
            this.PageSize = pageSize;
        }
    }

    public class GetJobPostWithPaginationQueryHandler : IRequestHandler<GetJobPostWithPaginationQuery, PaginatedResult<GetJobPostWithPaginationDto>>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public GetJobPostWithPaginationQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<PaginatedResult<GetJobPostWithPaginationDto>> Handle(GetJobPostWithPaginationQuery request, CancellationToken cancellationToken)
        {
            var JobPosts = await unitOfWork.Repository<JobPost>().GetAllAsync();
            var result = new List<GetJobPostWithPaginationDto>();
            foreach (var jobPost in JobPosts)
            {
                var jobPostDto = mapper.Map<GetJobPostWithPaginationDto>(jobPost);
                result.Add(jobPostDto);
            }
            throw new NotImplementedException();
        }
    }
}
