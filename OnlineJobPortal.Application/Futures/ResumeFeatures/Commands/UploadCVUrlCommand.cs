using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.ResumeFeatures.Commands
{
    public class UploadCVUrlCommand : IRequest<string?>
    {
        public UploadCVUrlCommand(int candidateId, string cvUrl)
        {
            CandidateId = candidateId;
            CvUrl = cvUrl;
        }

        public int CandidateId { get; }
        public string CvUrl { get; }
    }

    public class UploadCVUrlCommandHandler : IRequestHandler<UploadCVUrlCommand, string?>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public UploadCVUrlCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<string?> Handle(UploadCVUrlCommand request, CancellationToken cancellationToken)
        {
            unitOfWork.BeginTransaction();
            try
            {
                var resume = await unitOfWork.Repository<Resume>().GetAll
                    .Include(r => r.Candidate)
                    .FirstOrDefaultAsync(r => r.CandidateId.Equals(request.CandidateId));
                if (resume == null)
                {
                    throw new Exception();
                }

                resume.CvUrl = request.CvUrl;
                await unitOfWork.Repository<Resume>().UpdateAsync(resume);
                unitOfWork.Commit();
                return resume.CvUrl;
            }
            catch
            {
                unitOfWork.Rollback();
                return null;
            }
        }
    }
}
