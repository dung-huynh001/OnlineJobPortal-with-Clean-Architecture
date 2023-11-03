using AutoMapper;
using MediatR;
using OnlineJobPortal.Application.DTOs.CompanyDto;
using OnlineJobPortal.Application.DTOs.JobPostDto;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Application.Responses;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.CompanyFeatures.Queries
{
    public record GetCompanyWithPaginationQuery : IRequest<PaginatedResult<GetCompanyWithPaginationDto>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public GetCompanyWithPaginationQuery() { }
        public GetCompanyWithPaginationQuery(int pageNumber, int pageSize)
        {
            this.PageNumber = pageNumber;
            this.PageSize = pageSize;
        }
    }

    public class GetCompanyWithPaginationQueryHandler : IRequestHandler<GetCompanyWithPaginationQuery, PaginatedResult<GetCompanyWithPaginationDto>>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public GetCompanyWithPaginationQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<PaginatedResult<GetCompanyWithPaginationDto>> Handle(GetCompanyWithPaginationQuery request, CancellationToken cancellationToken)
        {
            var Companies = unitOfWork.Repository<Company>().GetAll;
            List<GetCompanyWithPaginationDto> result = new List<GetCompanyWithPaginationDto>();
            foreach (var company in Companies)
            {
                var companyDto = mapper.Map<GetCompanyWithPaginationDto>(company);
                //var totalJob = await unitOfWork.JobPostRepository.GetTotalJobPostWithCompanyId(companyDto.Id);
                //companyDto.TotalJob = totalJob;
                result.Add(companyDto);
            }
            return await result.ToPaginatedListAsync<GetCompanyWithPaginationDto>(request.PageNumber, request.PageSize, cancellationToken);
        }
    }
}
