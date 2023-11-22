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

namespace OnlineJobPortal.Application.Futures.SaveCandidateFeatures.Commands
{
    public class DeleteSaveCandidateCommand : IRequest<bool>
    {
        public DeleteSaveCandidateCommand(int candidateId, int employerId)
        {
            CandidateId = candidateId;
            EmployerId = employerId;
        }

        public int CandidateId { get; }
        public int EmployerId { get; }
    }

    public class DeleteSaveCandidateCommandHandler : IRequestHandler<DeleteSaveCandidateCommand, bool>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public DeleteSaveCandidateCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<bool> Handle(DeleteSaveCandidateCommand request, CancellationToken cancellationToken)
        {
            unitOfWork.BeginTransaction();
            try
            {
                var employer = await unitOfWork.Repository<Employer>().GetByIdAsync(request.EmployerId);
                var saveCandidate = await unitOfWork.Repository<SaveCandidate>().GetAll
                    .FirstOrDefaultAsync(s => s.CandidateId == request.CandidateId && s.CompanyId == employer!.CompanyId);

                await unitOfWork.Repository<SaveCandidate>().DeleteByIdAsync(saveCandidate!.Id);

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
