using AutoMapper;
using MediatR;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.CompanyFeatures.Queries
{
    public class GetCompanyProfileQuery: IRequest<Company>
    {
        public int employerId { get; set; }
        public GetCompanyProfileQuery()
        {
            
        }

        public GetCompanyProfileQuery(int employerId)
        {
            this.employerId = employerId;
        }
    }

    public class GetCompanyProfileQueryHandler : IRequestHandler<GetCompanyProfileQuery, Company>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public GetCompanyProfileQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<Company> Handle(GetCompanyProfileQuery request, CancellationToken cancellationToken)
        {
            var result = await unitOfWork.CompanyRepository.GetCompanyByEmployerId(request.employerId);
            return result;
        }
    }

}
