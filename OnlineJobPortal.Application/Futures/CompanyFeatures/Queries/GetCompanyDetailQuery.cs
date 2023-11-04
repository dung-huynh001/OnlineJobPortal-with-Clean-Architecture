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
    public class GetCompanyDetailQuery : IRequest<Company>
    {
        public int Id { get; set; }
        public GetCompanyDetailQuery(int id)
        {
            Id = id;
        }
    }

    public class GetCompanyDetailQueryHandler : IRequestHandler<GetCompanyDetailQuery, Company>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public GetCompanyDetailQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<Company> Handle(GetCompanyDetailQuery request, CancellationToken cancellationToken)
        {
            var result = await unitOfWork.CompanyRepository.GetCompanyDetailById(request.Id);
            return result;
        }
    }
}
