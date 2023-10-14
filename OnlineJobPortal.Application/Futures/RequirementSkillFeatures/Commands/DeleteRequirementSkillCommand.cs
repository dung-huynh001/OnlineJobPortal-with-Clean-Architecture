using MediatR;
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
    public class DeleteRequirementSkillCommand : IRequest<ApiResponse>
    {
        public int Id { get; set; }
    }
    public class DeleteRequirementSkillCommandHandler : IRequestHandler<DeleteRequirementSkillCommand, ApiResponse>
    {
        private readonly IUnitOfWork unitOfWork;

        public DeleteRequirementSkillCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task<ApiResponse> Handle(DeleteRequirementSkillCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var requirement = await unitOfWork.Repository<RequirementSkill>().GetByIdAsync(request.Id);
                
                if (requirement == null)
                {
                    return new ApiResponse
                    {
                        Success = false,
                        Message = "Not found requirement skill to delete"
                    };
                }

                await unitOfWork.Repository<RequirementSkill>().DeleteAsync(requirement);
                await unitOfWork.SaveAsync(cancellationToken);


                return new ApiResponse
                {
                    Success = true,
                    Message = "Deleted requirement skill successfully.",
                    Data = requirement
                };
            }
            catch
            {
                return new ApiResponse
                {
                    Success = false,
                    Message = "Delete requirement skill failed! Something went wrong."
                };
            }
        }
    }
}
