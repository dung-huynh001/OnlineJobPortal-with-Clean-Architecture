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
        public JobPostDto JobPostDto { get; set; }
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
            var Response = new ApiResponse();
            var JobPost = _mapper.Map<JobPost>(request.JobPostDto);

            await _unitOfWork.Repository<JobPost>().AddAsync(JobPost);
            await _unitOfWork.SaveAsync(cancellationToken);

            Response.Success = true;
            Response.Message = "Post News Success";

            return Response;
        }
    }
}
