using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using OnlineJobPortal.Application.DTOs.JobPostDto;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.JobPostFeatures.Queries
{
    public record GetJobPostByCategoryQuery : IRequest<List<GetJobPostWithPaginationDto>>
    {
        public int Id { get; set; }
        public GetJobPostByCategoryQuery(int id)
        {
            Id = id;
        }
    }

    public class GetJobPostByCategoryQueryHandler : IRequestHandler<GetJobPostByCategoryQuery, List<GetJobPostWithPaginationDto>>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public GetJobPostByCategoryQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<List<GetJobPostWithPaginationDto>> Handle(GetJobPostByCategoryQuery request, CancellationToken cancellationToken)
        {
            var jobPosts = await unitOfWork.Repository<JobPost>().GetAll
                .Include(jp => jp.District)
                .ThenInclude(d => d.Province)
                .Include(jp => jp.RequirementSkills)
                .ThenInclude(rq => rq.Skill)
                .Include(jp => jp.Employer)
                .ThenInclude(e => e.Company)
                .Where(jp => jp.JobTypeId.Equals(request.Id))
                .ToListAsync();
            List<GetJobPostWithPaginationDto> result = new List<GetJobPostWithPaginationDto>();
            foreach (var jobPost in jobPosts)
            {
                var jobPostDto = mapper.Map<GetJobPostWithPaginationDto>(jobPost);
                jobPostDto.CompanyName = jobPost.Employer.Company.CompanyName;
                jobPostDto.Province = jobPost.District.Province.ProvinceName;
                jobPostDto.LogoUrl = jobPost.Employer.Company.LogoUrl;
                jobPostDto.Skills = new List<string>();
                foreach (var requirementSkill in jobPost.RequirementSkills)
                {
                    jobPostDto.Skills.Add(requirementSkill.Skill.SkillName);
                    jobPostDto.Level = requirementSkill.Level.ToString();
                }

                result.Add(jobPostDto);
            }
            return result;
        }
    }
}
