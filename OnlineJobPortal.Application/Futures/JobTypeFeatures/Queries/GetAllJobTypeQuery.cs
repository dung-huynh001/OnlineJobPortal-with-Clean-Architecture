using AutoMapper;
using MediatR;
using OnlineJobPortal.Application.DTOs.JobTypeDto;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.JobTypeFeatures.Queries
{
    public class GetAllJobTypeQuery : IRequest<List<JobTypeDto>>
    {
    }

    public class GetAllJobTypeQueryHandle : IRequestHandler<GetAllJobTypeQuery, List<JobTypeDto>>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public GetAllJobTypeQueryHandle(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<List<JobTypeDto>> Handle(GetAllJobTypeQuery request, CancellationToken cancellationToken)
        {
            var jobTypeListDto = new List<JobTypeDto>();
            var jobTypeList = await unitOfWork.Repository<JobType>().GetAllAsync();

            foreach (var jobType in jobTypeList)
            {
                var jobTypeDto = mapper.Map<JobTypeDto>(jobType);
                jobTypeListDto.Add(jobTypeDto);
            }

            return jobTypeListDto;
        }
    }
}
