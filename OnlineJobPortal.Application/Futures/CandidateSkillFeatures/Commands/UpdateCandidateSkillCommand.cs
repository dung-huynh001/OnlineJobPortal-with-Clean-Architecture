using AutoMapper;
using MediatR;
using OnlineJobPortal.Application.DTOs.CandidateSkillDto;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Application.Responses;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.CandidateSkillFeatures.Commands
{
    public class UpdateCandidateSkillCommand : IRequest<ApiResponse>
    {
        public UpdateCandidateSkillDto UpdateCandidateSkillDto { get; set; }
    }

    public class UpdateCandidateSkillCommandHandler : IRequestHandler<UpdateCandidateSkillCommand, ApiResponse>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public UpdateCandidateSkillCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<ApiResponse> Handle(UpdateCandidateSkillCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var candidateskill = await unitOfWork.Repository<CandidateSkill>().GetByIdAsync(request.UpdateCandidateSkillDto.Id);
                if (candidateskill != null)
                {
                    return new ApiResponse
                    {
                        Success = false,
                        Message = "Updated candidate skill successfully."
                    };
                }

                candidateskill = mapper.Map<CandidateSkill>(request.UpdateCandidateSkillDto);
                await unitOfWork.Repository<CandidateSkill>().UpdateAsync(candidateskill);
                await unitOfWork.SaveAsync(cancellationToken);

                return new ApiResponse
                {
                    Success = true,
                    Message = "Updated candidate skill successfully."
                };
            }
            catch
            {
                return new ApiResponse
                {
                    Success = false,
                    Message = "Updated candidate skill successfully."
                };
            }
        }
    }
}
