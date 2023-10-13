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
    public record CreateJobPostCommand : IRequest<ApiResponse>
    {
        public CreateJobPostDto CreateJobPostDto { get; set; }
    }

    public class CreateJobPostCommandHandler : IRequestHandler<CreateJobPostCommand, ApiResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateJobPostCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<ApiResponse> Handle(CreateJobPostCommand request, CancellationToken cancellationToken)
        {
            var JobPost = _mapper.Map<JobPost>(request.CreateJobPostDto);

            await _unitOfWork.Repository<JobPost>().AddAsync(JobPost);
            await _unitOfWork.SaveAsync(cancellationToken);


            return new ApiResponse
            {
                Success = true,
                Message = "Job post creation success!",
                Data = JobPost
            };
        }
    }
}
