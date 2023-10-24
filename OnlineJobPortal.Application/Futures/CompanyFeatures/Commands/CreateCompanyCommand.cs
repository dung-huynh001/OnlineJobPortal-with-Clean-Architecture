using AutoMapper;
using MediatR;
using OnlineJobPortal.Application.DTOs.CompanyDto;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Application.Responses;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.CompanyFeatures.Commands
{
    public class CreateCompanyCommand : IRequest<ApiResponse>
    {
        public CreateCompanyDto CompanyDto { get; set; }
    }

    public class CreateCompanyCommandHandler : IRequestHandler<CreateCompanyCommand, ApiResponse>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public CreateCompanyCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<ApiResponse> Handle(CreateCompanyCommand request, CancellationToken cancellationToken)
        {
            var company = mapper.Map<Company>(request.CompanyDto);

            await unitOfWork.Repository<Company>().AddAsync(company);
            await unitOfWork.SaveAsync(cancellationToken);

            return new ApiResponse
            {
                Success = true,
                Message = "Created company successfully.",
                Data = company
            };
        }
    }
}
