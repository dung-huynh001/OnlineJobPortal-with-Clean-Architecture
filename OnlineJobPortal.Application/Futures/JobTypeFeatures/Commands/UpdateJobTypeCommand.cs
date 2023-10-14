using MediatR;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Application.Responses;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.JobTypeFeatures.Commands
{
    public class UpdateJobTypeCommand : IRequest<ApiResponse>
    {
        public int Id { get; set; }
        public string JobTypeName { get; set; }
    }
    public class UpdateJobTypeCommandHandler : IRequestHandler<UpdateJobTypeCommand, ApiResponse>
    {
        private readonly IUnitOfWork unitOfWork;

        public UpdateJobTypeCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task<ApiResponse> Handle(UpdateJobTypeCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var jobtype = await unitOfWork.Repository<JobType>().GetByIdAsync(request.Id);

                if (jobtype == null)
                {
                    return new ApiResponse
                    {
                        Success = false,
                        Message = "Not found job type to update."
                    };
                }

                jobtype.JobTypeName = request.JobTypeName;
                await unitOfWork.Repository<JobType>().UpdateAsync(jobtype);
                await unitOfWork.SaveAsync(cancellationToken);

                return new ApiResponse
                {
                    Success = true,
                    Message = "Updated job type successfully.",
                    Data = jobtype
                };
            }
            catch
            {
                return new ApiResponse
                {
                    Success = false,
                    Message = "Update job type failed! Something went wrong.",
                };
            }
        }
    }
}
