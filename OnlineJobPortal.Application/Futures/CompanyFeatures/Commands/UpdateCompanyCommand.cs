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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace OnlineJobPortal.Application.Futures.CompanyFeatures.Commands
{
    public class UpdateCompanyCommand : IRequest<ApiResponse>
    {
        public UpdateCompanyDto Company { get; set; }
        public UpdateCompanyCommand()
        {
            Company = new UpdateCompanyDto();
        }
        public UpdateCompanyCommand(UpdateCompanyDto company)
        {
            Company = company;
        }
    }

    public class UpdateCompanyCommandHandler : IRequestHandler<UpdateCompanyCommand, ApiResponse>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public UpdateCompanyCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<ApiResponse> Handle(UpdateCompanyCommand request, CancellationToken cancellationToken)
        {
            unitOfWork.BeginTransaction();
            try
            {
                var company = await unitOfWork.Repository<Company>().GetByIdAsync(request.Company.Id);
                if (company == null)
                {
                    throw new Exception();
                }
                company = mapper.Map<Company>(request.Company);
                await unitOfWork.Repository<Company>().UpdateAsync(company);

                unitOfWork.Commit();
                return new ApiResponse
                {
                    Success = true,
                    Message = "Updated company successfully",
                    Data = company
                };
            }
            catch
            {
                unitOfWork.Rollback();
                return new ApiResponse
                {
                    Success = false,
                    Message = "Update company failed",
                };
            }
        }
    }
}
