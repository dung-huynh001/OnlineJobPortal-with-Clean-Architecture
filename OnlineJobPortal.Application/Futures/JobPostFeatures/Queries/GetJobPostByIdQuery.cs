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
    public class GetJobPostByIdQuery : IRequest<JobPost>
    {
        public int JobPostId { get; set; }
        public GetJobPostByIdQuery(int jobPostId)
        {
            JobPostId = jobPostId;
        }
    }

    public class GetJobPostByIdQueryHandler : IRequestHandler<GetJobPostByIdQuery, JobPost>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public GetJobPostByIdQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<JobPost> Handle(GetJobPostByIdQuery request, CancellationToken cancellationToken)
        {
            var jobPost = await unitOfWork.Repository<JobPost>().GetAll
                .Include(a => a.JobType)
                .Include(a => a.RequirementSkills).ThenInclude(rs => rs.Skill)
                .Include(a => a.Employer.Company.District.Province)
                .Include(a => a.Applications).ThenInclude(a => a.Candidate)
                .FirstOrDefaultAsync(a => a.Id == request.JobPostId, cancellationToken);
            
            return jobPost ??= new JobPost();
        }
    }
}