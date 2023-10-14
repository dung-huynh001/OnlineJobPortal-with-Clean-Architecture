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
    public class UpdateApplyCommand : IRequest<ApiResponse>
    {
        public int Id { get; set; }
        public int Status { get; set; }
    }

    public class UpdateApplyCommandHandler : IRequestHandler<UpdateApplyCommand, ApiResponse>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public UpdateApplyCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<ApiResponse> Handle(UpdateApplyCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var apply = await unitOfWork.Repository<Apply>().GetByIdAsync(request.Id);

                if (apply == null)
                {
                    return new ApiResponse
                    {
                        Success = false,
                        Message = "Not found apply to update."
                    };
                }

                apply.Status = request.Status;
                await unitOfWork.Repository<Apply>().UpdateAsync(apply);
                await unitOfWork.SaveAsync(cancellationToken);

                return new ApiResponse
                {
                    Success = true,
                    Message = "Update apply successfully."
                };
            }
            catch
            {
                return new ApiResponse
                {
                    Success = false,
                    Message = "Update apply failed! Something went wrong."
                };
            }
        }
    }
}
