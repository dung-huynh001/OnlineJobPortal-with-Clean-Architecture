using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using OnlineJobPortal.Application.DTOs.CompanyDto;
using OnlineJobPortal.Application.DTOs.JobPostDto;
using OnlineJobPortal.Application.DTOs.SkillDto;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.JobPostFeatures.Queries
{
    public class GetJobPostDetailQuery : IRequest<GetJobPostDetailDto>
    {
        public int Id { get; set; }
        public GetJobPostDetailQuery()
        {
            
        }
        public GetJobPostDetailQuery(int id)
        {
            Id = id;
        }
    }

    public class GetJobPostDetailQueryHandler : IRequestHandler<GetJobPostDetailQuery, GetJobPostDetailDto>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public GetJobPostDetailQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<GetJobPostDetailDto> Handle(GetJobPostDetailQuery request, CancellationToken cancellationToken)
        {
            var jobPost = await unitOfWork.JobPostRepository.GetJobPostWithAllProperties(request.Id);
            GetJobPostDetailDto result = mapper.Map<GetJobPostDetailDto>(jobPost);
            result.ProvinceName = jobPost.District.Province.ProvinceName;
            result.Company = mapper.Map<GetCompanyDto>(jobPost.Employer.Company);

            var favoriteJobs =  unitOfWork.Repository<JobFavorite>().GetAll
                .FirstOrDefault(f => f.JobPostId.Equals(jobPost.Id));

            if (favoriteJobs != null)
                result.Saved = true;

            return result;
        }
    }
}
