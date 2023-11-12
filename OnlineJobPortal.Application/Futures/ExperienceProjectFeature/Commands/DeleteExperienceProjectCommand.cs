using AutoMapper;
using MediatR;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.ExperienceProjectFeature.Commands
{
    public class DeleteExperienceProjectCommand : IRequest<int?>
    {
        public int Id { get; set; }
        public DeleteExperienceProjectCommand(int id)
        {
            Id = id;
        }
    }

    public class DeleteExperienceProjectCommandHandler : IRequestHandler<DeleteExperienceProjectCommand, int?>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public DeleteExperienceProjectCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<int?> Handle(DeleteExperienceProjectCommand request, CancellationToken cancellationToken)
        {
            unitOfWork.BeginTransaction();
            try
            {
                var result = await unitOfWork.Repository<ExperienceProject>().DeleteByIdAsync(request.Id);
                unitOfWork.Commit();
                return result;
            }
            catch
            {
                unitOfWork.Rollback();
                return null;
            }
        }
    }
}
