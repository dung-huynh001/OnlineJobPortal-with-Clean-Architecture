using AutoMapper;
using MediatR;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.JobPostFeatures.Commands
{
    public class UpdateJobPostCommand : IRequest<bool>
    {
        public UpdateJobPostCommand(int jobPostId)
        {
            JobPostId = jobPostId;
        }

        public int JobPostId { get; }
    }

    public class UpdateJobPostCommandHandler : IRequestHandler<UpdateJobPostCommand, bool>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public UpdateJobPostCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(UpdateJobPostCommand request, CancellationToken cancellationToken)
        {
            unitOfWork.BeginTransaction();
            try
            {
                var jobPost = await unitOfWork.Repository<JobPost>().DeleteByIdAsync(request.JobPostId);

                if (jobPost == 0) 
                {
                    return false;
                }
                unitOfWork.Commit();   
                return true;
            }
            catch
            {
                unitOfWork.Rollback();
                return false;
            }
        }
    }
}
