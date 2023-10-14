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
    public class CreateForeignLanguageCommand : IRequest<ApiResponse>
    {
        public ForeignLanguageDto ForeignLanguage { get; set; }
    }

    public class CreateForeignLanguageCommandHandler : IRequestHandler<CreateForeignLanguageCommand, ApiResponse>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public CreateForeignLanguageCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public async Task<ApiResponse> Handle(CreateForeignLanguageCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var foreignLanguage = mapper.Map<ForeignLanguage>(request.ForeignLanguage);

                await unitOfWork.Repository<ForeignLanguage>().AddAsync(foreignLanguage);
                await unitOfWork.SaveAsync(cancellationToken);

                return new ApiResponse
                {
                    Success = true,
                    Message = "Foreign Language Creation success.",
                    Data = foreignLanguage.Id
                };
            }
            catch
            {
                return new ApiResponse
                {
                    Success = false,
                    Message = "Foreign Language Creation failed.",
                };
            }
        }
    }
}
