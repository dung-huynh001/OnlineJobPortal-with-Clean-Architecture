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

namespace OnlineJobPortal.Application.Futures.ForeignLangugeFeatures.Commands
{
    public class DeleteForeignLanguageCommand : IRequest<int?>
    {
        public DeleteForeignLanguageCommand(int id)
        {
            Id = id;
        }

        public int Id { get; }
    }
    public class DeleteForeignLanguageCommandHandler : IRequestHandler<DeleteForeignLanguageCommand, int?>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public DeleteForeignLanguageCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<int?> Handle(DeleteForeignLanguageCommand request, CancellationToken cancellationToken)
        {
            unitOfWork.BeginTransaction();
            try
            {
                var result = await unitOfWork.Repository<ForeignLanguage>().DeleteByIdAsync(request.Id);
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
