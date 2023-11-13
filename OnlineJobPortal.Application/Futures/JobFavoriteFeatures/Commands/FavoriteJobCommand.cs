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

namespace OnlineJobPortal.Application.Futures.JobFavoriteFeatures.Commands
{
    public class FavoriteJobCommand : IRequest<int?>
    {
        public FavoriteJobCommand(int jobId, int candidateId)
        {
            JobId = jobId;
            CandidateId = candidateId;
        }

        public int JobId { get; }
        public int CandidateId { get; }
    }
    public class FavoriteJobCommandHandler : IRequestHandler<FavoriteJobCommand, int?>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public FavoriteJobCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<int?> Handle(FavoriteJobCommand request, CancellationToken cancellationToken)
        {
            unitOfWork.BeginTransaction();
            try
            {
                var jobFavorite = new JobFavorite();
                jobFavorite.CandidateId = request.CandidateId;
                jobFavorite.JobPostId = request.JobId;

                await unitOfWork.Repository<JobFavorite>().AddAsync(jobFavorite);
                unitOfWork.Commit();
                return jobFavorite.Id;
            }
            catch
            {
                unitOfWork.Rollback();
                return null;
            }
        }
    }
}
