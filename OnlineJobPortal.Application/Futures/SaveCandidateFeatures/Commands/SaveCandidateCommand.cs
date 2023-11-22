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
    public class SaveCandidateCommand : IRequest<bool>
    {
        public SaveCandidateCommand(int candidateId, int employerId)
        {
            CandidateId = candidateId;
            EmployerId = employerId;
        }

        public int CandidateId { get; }
        public int EmployerId { get; }
    }

    public class SaveCandidateCommandHandler : IRequestHandler<SaveCandidateCommand, bool>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public SaveCandidateCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(SaveCandidateCommand request, CancellationToken cancellationToken)
        {
            unitOfWork.BeginTransaction();
            try
            {
                var saveCandidate = new SaveCandidate();

                var employer = await unitOfWork.Repository<Employer>().GetByIdAsync(request.EmployerId);

                saveCandidate.CandidateId = request.CandidateId;
                saveCandidate.CompanyId = employer!.CompanyId;

                var exist = await unitOfWork.Repository<SaveCandidate>().GetAll
                    .FirstOrDefaultAsync(s => s.CandidateId == request.CandidateId && s.CompanyId == employer.CompanyId);

                if(exist != null)
                {
                    return false;
                }

                await unitOfWork.Repository<SaveCandidate>().AddAsync(saveCandidate);
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
