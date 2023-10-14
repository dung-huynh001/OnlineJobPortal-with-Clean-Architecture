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
    public class UpdateRequirementSkillCommand : IRequest<ApiResponse>
    {
        public UpdateRequirementSkillDto UpdateRequirementSkillDto { get; set; } 
    }
    public class UpdateRequirementSkillCommandHandler : IRequestHandler<UpdateRequirementSkillCommand, ApiResponse>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public UpdateRequirementSkillCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<ApiResponse> Handle(UpdateRequirementSkillCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var requirement = await unitOfWork.Repository<RequirementSkill>().GetByIdAsync(request.UpdateRequirementSkillDto.Id);
                if (requirement == null)
                {
                    return new ApiResponse
                    {
                        Success = false,
                        Message = "Not found requirement skill to update"
                    };
                }

                requirement = mapper.Map<RequirementSkill>(requirement);

                await unitOfWork.Repository<RequirementSkill>().UpdateAsync(requirement);
                await unitOfWork.SaveAsync(cancellationToken);

                return new ApiResponse
                {
                    Success = true,
                    Message = "Updated requirement skill successfully.",
                    Data = requirement
                };
            }
            catch
            {
                return new ApiResponse
                {
                    Success = false,
                    Message = "Update requirement skill failed! Something went wrong."
                };
            }
        }
    }
}
