using AutoMapper;
using MediatR;
using OnlineJobPortal.Application.DTOs.SkillDto;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Application.Responses;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.SkillFeatures.Commands
{
    public class CreateSkillCommand : IRequest<ApiResponse>
    {
        public CreateSkillDto CreateSkillDto { get; set; }
    }

    public class CreateSkillCommandHandler : IRequestHandler<CreateSkillCommand, ApiResponse>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public CreateSkillCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }

        public async Task<ApiResponse> Handle(CreateSkillCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var skill = mapper.Map<Skill>(request.CreateSkillDto);

                await unitOfWork.Repository<Skill>().AddAsync(skill);
                await unitOfWork.SaveAsync(cancellationToken);

                return new ApiResponse
                {
                    Success = true,
                    Message = "Skill Creation success.",
                    Data = skill
                };
            }
            catch
            {
                return new ApiResponse
                {
                    Success = false,
                    Message = "Skill creation failed."
                };
            }
        }
    }
}
