using AutoMapper;
using MediatR;
using OnlineJobPortal.Application.DTOs.RequirementSkillDto;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Application.Responses;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.RequirementSkillFeatures.Commands
{
    public class CreateRequirementSkillCommand : IRequest<ApiResponse>
    {
        public CreateRequirementSkillDto CreateRequirementSkillDto { get; set; }
    }
    public class CreateRequirementSkillCommandHandler : IRequestHandler<CreateRequirementSkillCommand, ApiResponse>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public CreateRequirementSkillCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<ApiResponse> Handle(CreateRequirementSkillCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var requirement = mapper.Map<RequirementSkill>(request.CreateRequirementSkillDto);
                
                await unitOfWork.Repository<RequirementSkill>().AddAsync(requirement);
                await unitOfWork.SaveAsync(cancellationToken);

                return new ApiResponse
                {
                    Success = true,
                    Message = "Created requirement skill successfully.",
                    Data = requirement
                };
            }
            catch
            {
                return new ApiResponse
                {
                    Success = false,
                    Message = "Create requirement skill failed! Something went wrong.",
                };
            }
        }
    }
}