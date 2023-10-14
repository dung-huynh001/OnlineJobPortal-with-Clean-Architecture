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
    public class CreateJobTypeCommand : IRequest<ApiResponse>
    {
        public string JobTypeName { get; set; }
    }
    public class CreateJobTypeCommandHandler : IRequestHandler<CreateJobTypeCommand, ApiResponse>
    {
        private readonly IUnitOfWork unitOfWork;

        public CreateJobTypeCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<ApiResponse> Handle(CreateJobTypeCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var jobtype = new JobType
                {
                    JobTypeName = request.JobTypeName
                };

                await unitOfWork.Repository<JobType>().AddAsync(jobtype);
                await unitOfWork.SaveAsync(cancellationToken);

                return new ApiResponse
                {
                    Success = true,
                    Message = "Created job type successfully."
                };
            }
            catch
            {
                return new ApiResponse
                {
                    Success = true,
                    Message = "Create job type failed! Something went wrong."
                };
            }
        }
    }
}
