using AutoMapper;
using MediatR;
using OnlineJobPortal.Application.DTOs.ForeignLanguageDto;
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
    public class AddForeignLanguageCommand : IRequest<ForeignLanguage?>
    {
        public ForeignLanguage ForeignLanguage { get; }

        public AddForeignLanguageCommand(ForeignLanguage foreignLanguage)
        {
            ForeignLanguage = foreignLanguage;
        }
    }

    public class AddForeignLanguageCommandHandler : IRequestHandler<AddForeignLanguageCommand, ForeignLanguage?>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public AddForeignLanguageCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<ForeignLanguage?> Handle(AddForeignLanguageCommand request, CancellationToken cancellationToken)
        {
            unitOfWork.BeginTransaction();
            try
            {
                var foreignLanguage = request.ForeignLanguage;

                await unitOfWork.Repository<ForeignLanguage>().AddAsync(foreignLanguage);
                unitOfWork.Commit();

                return foreignLanguage;
            }
            catch
            {
                unitOfWork.Rollback();
                return null;
            }
        }
    }
}
