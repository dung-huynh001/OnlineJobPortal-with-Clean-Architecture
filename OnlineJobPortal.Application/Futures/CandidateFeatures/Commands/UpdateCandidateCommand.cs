using AutoMapper;
using MediatR;
using OnlineJobPortal.Application.DTOs.CandidateDto;
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
    public class UpdateCandidateCommand : IRequest<ApiResponse>
    {
        public UpdateCandidateDto UpdateCandidateDto { get; set; }
    }

    public class UpdateCandidateCommandHandler : IRequestHandler<UpdateCandidateCommand, ApiResponse>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public UpdateCandidateCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<ApiResponse> Handle(UpdateCandidateCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var candidate = await unitOfWork.Repository<Candidate>().GetByIdAsync(request.UpdateCandidateDto.Id);
                if (candidate == null)
                {
                    return new ApiResponse
                    {
                        Success = false,
                        Message = "Not found candidate to update"
                    };
                }

                candidate = mapper.Map<Candidate>(request.UpdateCandidateDto);
                await unitOfWork.Repository<Candidate>().UpdateAsync(candidate);
                await unitOfWork.SaveAsync(cancellationToken);

                return new ApiResponse
                {
                    Success = true,
                    Message = "Updated candidate successfully.",
                    Data = candidate
                };
            }
            catch
            {
                return new ApiResponse
                {
                    Success = true,
                    Message = "Update candidate failed! Something went wrong.",
                };
            }
        }
    }
}
