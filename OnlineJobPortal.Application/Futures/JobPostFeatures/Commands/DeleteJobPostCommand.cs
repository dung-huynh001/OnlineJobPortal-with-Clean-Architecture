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

namespace OnlineJobPortal.Application.Futures.JobPostFeatures.Commands
{
    public class DeleteJobPostCommand : IRequest<ApiResponse>
    {
        public JobPostDto JobPostDto { get; set; }
    }

    public class DeleteJobPostCommandHandler : IRequestHandler<DeleteJobPostCommand, ApiResponse>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public DeleteJobPostCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<ApiResponse> Handle(DeleteJobPostCommand request, CancellationToken cancellationToken)
        {
            var JobPost = mapper.Map<JobPost>(request);

            await unitOfWork.Repository<JobPost>().UpdateAsync(JobPost);
            await unitOfWork.SaveAsync(cancellationToken);

            return new ApiResponse
            {
                Success = true,
                Message = "Update Job Post success!"
            };
        }
    }
}
