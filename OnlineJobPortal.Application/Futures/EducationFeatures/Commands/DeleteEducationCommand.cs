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

namespace OnlineJobPortal.Application.Futures.EducationFeatures.Commands
{
    public class DeleteEducationCommand : IRequest<int?>
    {
        public int Id { get; set; }
        public DeleteEducationCommand(int id)
        {
            Id = id;
        }
    }
    public class DeleteEducationCommandHandler : IRequestHandler<DeleteEducationCommand, int?>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;
        public DeleteEducationCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<int?> Handle(DeleteEducationCommand request, CancellationToken cancellationToken)
        {
            unitOfWork.BeginTransaction();
            try
            {
                var result = await unitOfWork.Repository<Education>().DeleteByIdAsync(request.Id);
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
