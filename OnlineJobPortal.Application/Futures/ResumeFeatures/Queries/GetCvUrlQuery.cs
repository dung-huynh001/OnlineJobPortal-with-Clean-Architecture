using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.ResumeFeatures.Queries
{
    public class GetCvUrlQuery : IRequest<string?>
    {
        public GetCvUrlQuery(int candidateId)
        {
            CandidateId = candidateId;
        }

        public int CandidateId { get; }
    }

    public class GetCvUrlQueryHandler : IRequestHandler<GetCvUrlQuery, string?>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public GetCvUrlQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<string?> Handle(GetCvUrlQuery request, CancellationToken cancellationToken)
        {
            unitOfWork.BeginTransaction();
            try
            {
                var resume = await unitOfWork.Repository<Resume>().GetAll
                    .FirstOrDefaultAsync(r => r.CandidateId.Equals(request.CandidateId));
                if (resume == null) throw new Exception();
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
