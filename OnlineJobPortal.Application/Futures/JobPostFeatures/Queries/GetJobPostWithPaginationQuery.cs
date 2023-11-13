using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
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
    public record GetJobPostWithPaginationQuery : IRequest<PaginatedResult<GetJobPostWithPaginationDto>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int CandidateId { get; set; }
        public GetJobPostWithPaginationQuery(int candidateId, int pageNumber, int pageSize)
        {
            CandidateId = candidateId;
            PageNumber = pageNumber;
            PageSize = pageSize;
        }
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
                if(request.CandidateId != 0)
                {
                    var jobFavorite = await unitOfWork.Repository<JobFavorite>().GetAll
                        .FirstOrDefaultAsync(j => j.CandidateId.Equals(request.CandidateId) &&
                        j.JobPostId.Equals(jobPostDto.Id));
                    if(jobFavorite != null)
                    {
                        jobPostDto.Saved = true;
                    }
                }
                jobPostDto.Skills = skills;
                jobPostDto.Province = await unitOfWork.ProvinceRepository.GetProvinceNameById(jobPost.ProvinceId);
                result.Add(jobPostDto);
            }
            return await result.ToPaginatedListAsync<GetJobPostWithPaginationDto>(request.PageNumber, request.PageSize, cancellationToken);
        }
    }
}
