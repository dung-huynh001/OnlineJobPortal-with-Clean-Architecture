using MediatR;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Application.Responses;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.JobTypeFeatures.Commands
{
    public class DeleteJobTypeCommand : IRequest<ApiResponse>
    {
        public int Id { get; set; }
    }
    public class DeleteJobTypeCommandHanler : IRequestHandler<DeleteJobTypeCommand, ApiResponse>
    {
        private readonly IUnitOfWork unitOfWork;

        public DeleteJobTypeCommandHanler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task<ApiResponse> Handle(DeleteJobTypeCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var jobtype = await unitOfWork.Repository<JobType>().GetByIdAsync(request.Id);

                if(jobtype == null)
                {
                    return new ApiResponse
                    {
                        Success = false,
                        Message = "Not found job type to delete."
                    };
                }

                await unitOfWork.Repository<JobType>().DeleteAsync(jobtype);
                await unitOfWork.SaveAsync(cancellationToken);

                return new ApiResponse
                {
                    Success = true,
                    Message = "Delete job type failed! Something went wrong."
                };
            }
            catch
            {
                return new ApiResponse
                {
                    Success = false,
                    Message = "Delete job type failed! Something went wrong."
                };
            }
        }
    }
}
