using AutoMapper;
using MediatR;
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
    public class DeleteCandidateSkillCommand : IRequest<ApiResponse>
    {
        public int Id { get; set; }
    }

    public class DeleteCandidateSkillCommandHandler : IRequestHandler<DeleteCandidateSkillCommand, ApiResponse>
    {
        private readonly IUnitOfWork unitOfWork;

        public DeleteCandidateSkillCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task<ApiResponse> Handle(DeleteCandidateSkillCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var candidateskill = await unitOfWork.Repository<CandidateSkill>().GetByIdAsync(request.Id);
                if (candidateskill != null)
                {
                    return new ApiResponse
                    {
                        Success = false,
                        Message = "Not found candidate skill to delete"
                    };
                }

                await unitOfWork.Repository<CandidateSkill>().DeleteAsync(candidateskill);
                await unitOfWork.SaveAsync(cancellationToken);

                return new ApiResponse
                {
                    Success = true,
                    Message = "Deleted candidate skill successfully."
                };
            }
            catch
            {
                return new ApiResponse
                {
                    Success = false,
                    Message = "Delete candidate skill failed! Something went wrong."
                };
            }
        }
    }
}
