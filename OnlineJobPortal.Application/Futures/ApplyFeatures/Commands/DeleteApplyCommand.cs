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

namespace OnlineJobPortal.Application.Futures.ApplyFeatures.Commands
{
    public class DeleteApplyCommand : IRequest<ApiResponse>
    {
        public int Id { get; set; }
    }

    public class DeleteApplyCommandHandler : IRequestHandler<DeleteApplyCommand, ApiResponse>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public DeleteApplyCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<ApiResponse> Handle(DeleteApplyCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var apply = await unitOfWork.Repository<Apply>().GetByIdAsync(request.Id);

                if(apply == null)
                {
                    return new ApiResponse
                    {
                        Success = false,
                        Message = "Not found apply to delete."
                    };
                }

                await unitOfWork.Repository<Apply>().DeleteAsync(apply);
                await unitOfWork.SaveAsync(cancellationToken);

                return new ApiResponse
                {
                    Success = true,
                    Message = "Deleted apply successfully.",
                    Data = ""
                };
            }
            catch
            {
                return new ApiResponse
                {
                    Success = false,
                    Message = "Deleted apply failed! Something went wrong.",
                };
            }
        }
    }
}
