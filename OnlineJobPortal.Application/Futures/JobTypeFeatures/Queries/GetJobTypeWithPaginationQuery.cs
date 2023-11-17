using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using OnlineJobPortal.Application.DTOs.JobTypeDto;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Application.Responses;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.JobTypeFeatures.Queries
{
    public record GetJobTypeWithPaginationQuery : IRequest<PaginatedResult<GetJobTypeWithPaginationDto>>
    {
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
        public GetJobTypeWithPaginationQuery()
        {
            
        }

        public GetJobTypeWithPaginationQuery(int pageNumber, int pageSize)
        {
            this.PageNumber = pageNumber;
            this.PageSize = pageSize;
        }
    }

    public class GetJobTypeWithPaginationQueryHandler : IRequestHandler<GetJobTypeWithPaginationQuery, PaginatedResult<GetJobTypeWithPaginationDto>>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public GetJobTypeWithPaginationQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<PaginatedResult<GetJobTypeWithPaginationDto>> Handle(GetJobTypeWithPaginationQuery request, CancellationToken cancellationToken)
        {
            var result =  await unitOfWork.JobTypeRepository.GetAllJobTypeWithTotalJobPost();
            result = result.OrderByDescending(r => r.TotalJobPost).ToList();
            return await result.ToPaginatedListAsync(request.PageNumber, request.PageSize, cancellationToken);
        }
    }
}
