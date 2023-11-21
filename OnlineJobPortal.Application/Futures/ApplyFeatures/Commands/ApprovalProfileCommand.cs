using AutoMapper;
using MediatR;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.ApplyFeatures.Commands
{
    public class ApprovalProfileCommand : IRequest<bool>
    {
        public ApprovalProfileCommand(int applyId)
        {
            ApplyId = applyId;
        }

        public int ApplyId { get; }
    }

    public class ApprovalProfileCommandHandler : IRequestHandler<ApprovalProfileCommand,  bool>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public ApprovalProfileCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(ApprovalProfileCommand request, CancellationToken cancellationToken)
        {
            unitOfWork.BeginTransaction();
            try
            {
                var apply = await unitOfWork.Repository<Apply>().GetByIdAsync(request.ApplyId);
                apply!.Status = "Passed";

                await unitOfWork.Repository<Apply>().UpdateAsync(apply);
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
