using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
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
    public record GetJobPostByCompanyIdQuery : IRequest<PaginatedResult<GetJobPostWithPaginationDto>>
    {
        public int Id { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public GetJobPostByCompanyIdQuery() { }
        public GetJobPostByCompanyIdQuery(int id, int pageNumber, int pageSize)
        {
            this.Id = id;
            this.PageNumber = pageNumber;
            this.PageSize = pageSize;
        }
    }

    public class GetJobPostByCompanyIdQueryHandler : IRequestHandler<GetJobPostByCompanyIdQuery, PaginatedResult<GetJobPostWithPaginationDto>>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public GetJobPostByCompanyIdQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<PaginatedResult<GetJobPostWithPaginationDto>> Handle(GetJobPostByCompanyIdQuery request, CancellationToken cancellationToken)
        {
            var JobPosts = await unitOfWork.Repository<JobPost>().GetAll
                .Include(jp => jp.Employer)
                .ThenInclude(e => e.Company)
                .Include(jp => jp.RequirementSkills)
                .ThenInclude(rs => rs.Skill)
                .Include(jp => jp.District)
                .ThenInclude(d => d.Province)
                .Where(c => c.Employer.CompanyId.Equals(request.Id))
                .ToListAsync();
            List<GetJobPostWithPaginationDto> result = new List<GetJobPostWithPaginationDto>();
            foreach (var jobPost in JobPosts)
            {
                var jobPostDto = mapper.Map<GetJobPostWithPaginationDto>(jobPost);

                jobPostDto.CompanyId = jobPost.Employer.CompanyId;
                jobPostDto.CompanyName = jobPost.Employer.Company.CompanyName;
                jobPostDto.LogoUrl = jobPost.Employer.Company.LogoUrl;
                jobPostDto.Skills = new List<string>();

                foreach (var requirementSkill in jobPost.RequirementSkills)
                {
                    jobPostDto.Skills.Add(requirementSkill.Skill.SkillName);
                }
                jobPostDto.Province = jobPost.District.Province.ProvinceName;
                result.Add(jobPostDto);
            }
            return await result.ToPaginatedListAsync<GetJobPostWithPaginationDto>(request.PageNumber, request.PageSize, cancellationToken);
        }
    }
}
