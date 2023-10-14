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
    public class CreateCandidateSkillCommand : IRequest<ApiResponse>
    {
        public CreateCandidateSkillDto CreateCandidateSkillDto { get; set; }
    }

    public class CreateCandidateSkillCommandHandler : IRequestHandler<CreateCandidateSkillCommand, ApiResponse>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public CreateCandidateSkillCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<ApiResponse> Handle(CreateCandidateSkillCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var candidateskill = mapper.Map<CandidateSkill>(request.CreateCandidateSkillDto);

                await unitOfWork.Repository<CandidateSkill>().AddAsync(candidateskill);
                await unitOfWork.SaveAsync(cancellationToken);

                return new ApiResponse
                {
                    Success = true,
                    Message = "Created candidate skill successfully.",
                    Data = candidateskill
                };
            }
            catch
            {
                return new ApiResponse
                {
                    Success = false,
                    Message = "Create candidate skill failed! Something went wrong."
                };
            }
        }
    }
}
