using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using OnlineJobPortal.Application.DTOs.BussinessIndustryDto;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.BussinessIndustryFeatures.Queries
{
    public record GetAllBussinessIndustryQuery : IRequest<List<GetBussinessIndustryDto>>
    {
    }

    public class GetAllBussinessIndustryQueryHandler : IRequestHandler<GetAllBussinessIndustryQuery, List<GetBussinessIndustryDto>>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public GetAllBussinessIndustryQueryHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<List<GetBussinessIndustryDto>> Handle(GetAllBussinessIndustryQuery request, CancellationToken cancellationToken)
        {
            var result = await unitOfWork.Repository<BussinessIndustry>().GetAll
                .ProjectTo<GetBussinessIndustryDto>(mapper.ConfigurationProvider)
                .ToListAsync();
            return result;
        }
    }
}
