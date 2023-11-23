using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.CompanyFeatures.Queries
{
    public class VerifyCompanyInfoQuery : IRequest<bool>
    {
        public VerifyCompanyInfoQuery(int employerId)
        {
            EmployerId = employerId;
        }

        public int EmployerId { get; }
    }

    public class VerifyCompanyInfoQueryHandler : IRequestHandler<VerifyCompanyInfoQuery, bool>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public VerifyCompanyInfoQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<bool> Handle(VerifyCompanyInfoQuery request, CancellationToken cancellationToken)
        {
            var employer = await unitOfWork.Repository<Employer>().GetByIdAsync(request.EmployerId);
            var company = await unitOfWork.Repository<Company>().GetByIdAsync(employer!.CompanyId);
            if(company!.Owner == null || company.Description == null || 
                company.BussinessIndustryId == null || company.Email == null || company.Hotline == null)
                return false;
            return true;
        }
    }
}
