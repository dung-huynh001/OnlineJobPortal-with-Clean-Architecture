using MediatR;
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
    public class DeleteCandidateCommand : IRequest<ApiResponse>
    {
        public int Id { get; set; }
    }

    public class DeleteCandidateCommandHandler : IRequestHandler<DeleteCandidateCommand, ApiResponse>
    {
        private readonly IUnitOfWork unitOfWork;

        public DeleteCandidateCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task<ApiResponse> Handle(DeleteCandidateCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var candidate = await unitOfWork.Repository<Candidate>().GetByIdAsync(request.Id);

                if (candidate == null)
                {
                    return new ApiResponse
                    {
                        Success = false,
                        Message = "Not found candidate to delete."
                    };
                }
                
                await unitOfWork.Repository<Candidate>().DeleteAsync(candidate);
                await unitOfWork.SaveAsync(cancellationToken);

                return new ApiResponse
                {
                    Success = true,
                    Message = "Deleted candidate successfully.",
                    Data = candidate
                };
            }
            catch
            {
                return new ApiResponse
                {
                    Success = true,
                    Message = "Delete candidate failed! Something went wrong.",
                };
            }
        }
    }
}
