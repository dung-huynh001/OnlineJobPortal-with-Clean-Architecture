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
    public class MarkViewedProfileCommand : IRequest<bool>
    {
        public MarkViewedProfileCommand(int applyId)
        {
            ApplyId = applyId;
        }

        public int ApplyId { get; }
    }

    public class MarkViewedProfileCommandHandler : IRequestHandler<MarkViewedProfileCommand, bool>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public MarkViewedProfileCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<bool> Handle(MarkViewedProfileCommand request, CancellationToken cancellationToken)
        {
            unitOfWork.BeginTransaction();
            try
            {
                var apply = await unitOfWork.Repository<Apply>().GetByIdAsync(request.ApplyId);
                if(apply == null) { return false; }

                if(apply.Status.ToLower() != "pending")
                {
                    return false;
                }
                apply.Status = "Viewed";

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
