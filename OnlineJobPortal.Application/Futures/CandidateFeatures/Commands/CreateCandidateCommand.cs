using AutoMapper;
using MediatR;
using OnlineJobPortal.Application.DTOs.ApplicationDto;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Application.Responses;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.CandidateFeatures.Commands
{
    public record CreateCandidateCommand : IRequest<ApiResponse>
    {
        public CreateAdminDto CreateAdminDto { get; set; }
    }
    public class CreateCandidateCommandHandler : IRequestHandler<CreateCandidateCommand, ApiResponse>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public CreateCandidateCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }

        public async Task<ApiResponse> Handle(CreateCandidateCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var candidate = mapper.Map<Candidate>(request.CreateAdminDto);

                await unitOfWork.Repository<Candidate>().AddAsync(candidate);
                await unitOfWork.SaveAsync(cancellationToken);

                return new ApiResponse
                {
                    Success = true,
                    Message = "Created candidate successfully.",
                    Data = candidate
                };
            }
            catch
            {
                return new ApiResponse
                {
                    Success = false,
                    Message = "Create candidate failed! Something went wrong."
                };
            }
        }
    }
}
