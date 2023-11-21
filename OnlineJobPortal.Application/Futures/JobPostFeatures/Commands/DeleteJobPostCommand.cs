using AutoMapper;
using MediatR;
using OnlineJobPortal.Application.DTOs.JobPostDto;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Application.Responses;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.JobPostFeatures.Commands
{
    public class DeleteJobPostCommand : IRequest<bool>
    {
        public DeleteJobPostCommand(int jobPostId)
        {
            JobPostId = jobPostId;
        }
        public int JobPostId { get; }
    }

    public class DeleteJobPostCommandHandler : IRequestHandler<DeleteJobPostCommand, bool>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public DeleteJobPostCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<bool> Handle(DeleteJobPostCommand request, CancellationToken cancellationToken)
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
