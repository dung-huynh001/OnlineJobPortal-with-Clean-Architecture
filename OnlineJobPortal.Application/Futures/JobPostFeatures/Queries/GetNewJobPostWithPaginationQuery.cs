using AutoMapper;
using MediatR;
using OnlineJobPortal.Application.DTOs.JobPostDto;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Application.Interfaces.Repositories;
using OnlineJobPortal.Application.Responses;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.JobPostFeatures.Queries
{
    public record GetNewJobPostWithPaginationQuery : IRequest<PaginatedResult<GetJobPostWithPaginationDto>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public GetNewJobPostWithPaginationQuery() { }
        public GetNewJobPostWithPaginationQuery(int pageNumber, int pageSize)
        {
            this.PageNumber = pageNumber;
            this.PageSize = pageSize;
        }
    }

    public class GetNewJobPostWithPaginationQueryHandler : IRequestHandler<GetNewJobPostWithPaginationQuery, PaginatedResult<GetJobPostWithPaginationDto>>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public GetNewJobPostWithPaginationQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<PaginatedResult<GetJobPostWithPaginationDto>> Handle(GetNewJobPostWithPaginationQuery request, CancellationToken cancellationToken)
        {
            var JobPosts = (await unitOfWork.Repository<JobPost>().GetAllAsync())
                .OrderBy(c => c.CreateAt);
            List<GetJobPostWithPaginationDto> result = new List<GetJobPostWithPaginationDto>();
            foreach (var jobPost in JobPosts)
            {
                var skills = await unitOfWork.RequirementSkillRepository.GetRequirementSkillsByJobPostId(jobPost.Id);
                var jobPostDto = mapper.Map<GetJobPostWithPaginationDto>(jobPost);
                var company = await unitOfWork.CompanyRepository.GetCompanyByEmployerId(jobPost.EmployerId);
                if(company != null)
                {
                    jobPostDto.CompanyId = company.Id;
                    jobPostDto.CompanyName = company.CompanyName;
                    jobPostDto.LogoUrl = company.LogoUrl;
                }
                jobPostDto.Skills = skills;
                jobPostDto.Province = await unitOfWork.ProvinceRepository.GetProvinceNameById(jobPost.ProvinceId);
                result.Add(jobPostDto);
            }
            return await result.ToPaginatedListAsync<GetJobPostWithPaginationDto>(request.PageNumber, request.PageSize, cancellationToken);
        }
    }
}
