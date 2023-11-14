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
    public class CancelJobCommand : IRequest<bool>
    {
        public CancelJobCommand(int id)
        {
            Id = id;
        }

        public int Id { get; }
    }

    public class CancelJobCommandHandler : IRequestHandler<CancelJobCommand, bool>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public CancelJobCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<bool> Handle(CancelJobCommand request, CancellationToken cancellationToken)
        {
            unitOfWork.BeginTransaction();
            try
            {
                var appliedJob = await unitOfWork.Repository<Apply>().GetByIdAsync(request.Id);
                if (appliedJob == null)
                {
                    throw new Exception();
                }

                appliedJob.Status = "cancelled";

                await unitOfWork.Repository<Apply>().UpdateAsync(appliedJob);

                unitOfWork.Commit();
                return true;
            }
            catch
            {
                unitOfWork.Rollback();
                return false;
            }
            throw new NotImplementedException();
        }
    }
}
