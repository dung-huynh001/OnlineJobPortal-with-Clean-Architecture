using AutoMapper;
using MediatR;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.ProjectFeatures.Commands
{
    public class DeleteProjectCommand : IRequest<int?>
    {
        public int Id { get;}

        public DeleteProjectCommand(int id)
        {
            Id = id;
        }
    }
    public class DeleteProjectCommandHand : IRequestHandler<DeleteProjectCommand, int?>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public DeleteProjectCommandHand(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<int?> Handle(DeleteProjectCommand request, CancellationToken cancellationToken)
        {
            unitOfWork.BeginTransaction();
            try
            {
                var projectId = await unitOfWork.Repository<Project>().DeleteByIdAsync(request.Id);
                unitOfWork.Commit();
                return projectId;
            }
            catch
            {
                unitOfWork.Rollback();
                return null;
            }
        }
    }
}
