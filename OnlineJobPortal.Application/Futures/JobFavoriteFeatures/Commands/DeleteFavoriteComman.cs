using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Application.Responses;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.JobFavoriteFeatures.Commands
{
    public class DeleteJobFavoriteCommand : IRequest<bool>
    {
        public DeleteJobFavoriteCommand(int jobId, int candidateId)
        {
            JobId = jobId;
            CandidateId = candidateId;
        }

        public int JobId { get; }
        public int CandidateId { get; }
    }
    public class DeleteJobFavoriteCommandHandler : IRequestHandler<DeleteJobFavoriteCommand, bool>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public DeleteJobFavoriteCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<bool> Handle(DeleteJobFavoriteCommand request, CancellationToken cancellationToken)
        {
            unitOfWork.BeginTransaction();
            try
            {
                var jobFavorite = await unitOfWork.Repository<JobFavorite>().GetAll
                    .FirstOrDefaultAsync(
                    j => j.CandidateId.Equals(request.CandidateId)
                    && j.JobPostId.Equals(request.JobId));
                if(jobFavorite == null)
                {
                    throw new ArgumentNullException();
                }

                await unitOfWork.Repository<JobFavorite>().DeleteByIdAsync(jobFavorite.Id);

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
